using UnityEngine;

public class LetterScript : MonoBehaviour
{
    [SerializeField] private Letter letter;
    public void WrongClick()
    {
        if (!letter.IsSecure)
        {
            AllInfluence.Instance.RightAnswers += 1;
        }
    }

    public void RightClick()
    {
        if (letter.IsSecure)
        {
            AllInfluence.Instance.RightAnswers += 1;
        }
    }
}
