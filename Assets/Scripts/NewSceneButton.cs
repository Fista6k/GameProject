using UnityEngine;
using UnityEngine.SceneManagement;

public class NewSceneButton : MonoBehaviour
{
    [SerializeField] private LocationData location;

    public void ChangeScenebyButton()
    {
        if (location != null)
        {
            SceneManager.LoadScene(location.sceneName);
        }
    }
}
