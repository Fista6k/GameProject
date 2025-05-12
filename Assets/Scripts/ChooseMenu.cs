using UnityEngine;
using UnityEngine.UI;

public class PopupManager : MonoBehaviour
{
    [SerializeField] private Image darkBackground;
    [SerializeField] private GameObject popupWindow;
    [SerializeField] private float fadeDuration = 0.6f;

    private void Start()
    {
        darkBackground.color = new Color(0, 0, 0, 0);
        darkBackground.raycastTarget = false;
        popupWindow.SetActive(true);
        FadeBackground(fadeDuration);
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