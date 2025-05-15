using UnityEngine;
using UnityEngine.UI;

public class ToMiniGameTrigger : MonoBehaviour
{
    [SerializeField] private Button button;

    public void Start()
    {
        button.gameObject.SetActive(false);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            button.gameObject.SetActive(true);
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            button.gameObject.SetActive(false);
        }
    }
}
