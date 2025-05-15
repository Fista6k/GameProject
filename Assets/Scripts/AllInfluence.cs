using UnityEngine;

public class AllInfluence : MonoBehaviour
{
    public static AllInfluence Instance;

    public int RightAnswers = 0;
    public bool HasBadge = false;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else 
        {
            Destroy(gameObject);
        }
    }
}
