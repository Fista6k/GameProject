using UnityEngine;
using UnityEngine.UI;

public class PopupManager : MonoBehaviour
{
    [SerializeField] private Image darkBackground;
    [SerializeField] private GameObject popupWindow;
    [SerializeField] private float fadeDuration = 0.6f;
    [SerializeField] private Button openButton;
    [SerializeField] private Button closeButton;

    private void Start()
    {
        FadeBackground(fadeDuration);
        popupWindow.SetActive(true);
        closeButton.gameObject.SetActive(true);
        openButton.gameObject.SetActive(false);
    }

    public void OpenClick()
    {
        openButton.gameObject.SetActive(false);
        closeButton.gameObject.SetActive(true);
        popupWindow.SetActive(true);
        darkBackground.gameObject.SetActive(true);
        FadeBackground(fadeDuration);
    }

    public void CloseClick()
    {
        closeButton.gameObject.SetActive(false);
        openButton.gameObject.SetActive(true);
        popupWindow.SetActive(false);
        darkBackground.gameObject.SetActive(false);
    }

    private void FadeBackground(float targetAlpha)
    {
        darkBackground.raycastTarget = targetAlpha > 0;
        StartCoroutine(FadeRoutine(targetAlpha));
    }

    private System.Collections.IEnumerator FadeRoutine(float targetAlpha)
    {
        float startAlpha = darkBackground.color.a;
        float elapsed = 0f;

        while (elapsed < fadeDuration)
        {
            float alpha = Mathf.Lerp(startAlpha, targetAlpha, elapsed / fadeDuration);
            darkBackground.color = new Color(0, 0, 0, alpha);
            elapsed += Time.deltaTime;
            yield return null;
        }
        darkBackground.color = new Color(0, 0, 0, targetAlpha);
    }
}