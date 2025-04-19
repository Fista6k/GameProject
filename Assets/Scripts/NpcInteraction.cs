using UnityEngine;
using UnityEngine.SceneManagement;

public class NpcInteracition : MonoBehaviour
{
    public GameObject questionMarkUI;
    public GameObject dialogUI;
    private bool playerInRange;
    public Transform NpcTransform;

    void Start()
    {
        questionMarkUI.SetActive(false);
        dialogUI.SetActive(false);
    }

    void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            dialogUI.SetActive(true);
        }

        if (dialogUI.activeSelf)
        {
            dialogUI.transform.position = NpcTransform.position + new Vector3(0, 5, 0);
        }
    }

    public void OnPLayMiniGame()
    {
        //SceneManager.LoadScene("MiniGame1");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            questionMarkUI.SetActive(true);
            playerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            questionMarkUI.SetActive(false);
            dialogUI.SetActive(false);
            playerInRange=false;
        }
    }
}
