using UnityEngine;

[CreateAssetMenu(fileName = "GridColors", menuName = "Configuration/Grid Colors")]
public class GridColor : ScriptableObject
{

    public Color CalmTileColor = Color.gray;
    public Color ActiveTileColor = new Color(0.25f, 0.65f, 0.20f);
    
}