using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NpcInteracition : MonoBehaviour
{
    [SerializeField] private GameObject questionMark;
    public GameObject dialogUI;
    public TextMeshProUGUI dialogText;

    private bool playerInRange;
    public Transform NpcTransform;

    [TextArea(3, 10)]
    public string[] dialogLines;
    private int currentLine = 0;

    void Start()
    {
        questionMark.SetActive(false);
        dialogUI.SetActive(false);

    }

    void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            questionMark.SetActive(false);
            if (!dialogUI.activeSelf)
            {
                dialogUI.SetActive(true);
                ShowDialogLine();
            }
            else
            {
                NextDialogLine();
            }
            
        }

        if (dialogUI.activeSelf)
        {
            dialogUI.transform.position = NpcTransform.position + new Vector3(0, 5, 0);
        }
    }

    private void ShowDialogLine()
    {
        if (currentLine < dialogLines.Length)
        {
            dialogText.text = dialogLines[currentLine];
        }
        else
        {
            dialogUI.SetActive(false);
        }
    }

    private void NextDialogLine()
    {
        currentLine++;
        ShowDialogLine();
    }

    public void OnPLayMiniGame()
    {
        //SceneManager.LoadScene("MiniGame1");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            questionMark.SetActive(true);
            playerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            questionMark.SetActive(false);
            dialogUI.SetActive(false);
            playerInRange=false;
            currentLine = 0;
        }
    }
}
