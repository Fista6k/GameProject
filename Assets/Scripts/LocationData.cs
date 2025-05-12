using UnityEngine;

[CreateAssetMenu(fileName = "NewLocation", menuName = "Location Data")]
public class LocationData : ScriptableObject
{
    public string locationName;
    public Sprite previewImage;
    public string sceneName;
}