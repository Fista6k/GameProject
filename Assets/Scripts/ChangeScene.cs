using UnityEditor.SearchService;
using UnityEditor.U2D;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour
{
    [Header("SceneName")]
    [SerializeField] private string sceneName;
    public void ChangeScene1()
    {
        SceneManager.LoadScene(sceneName);
    }
}
