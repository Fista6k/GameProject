using UnityEngine;

[CreateAssetMenu(fileName = "Letter1", menuName = "Scriptable Objects/Letter1")]
public class Letter : ScriptableObject
{
    public bool IsSecure;
    public string Name;
    public Sprite SpriteLetter;
}
