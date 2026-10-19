using UnityEngine;

[CreateAssetMenu(fileName = "GridColors", menuName = "Configuration/Grid Colors")]
public class GridColor : ScriptableObject
{

    public Color CalmTileColor = new Color(0.72f, 0.74f, 0.75f);
    public Color ActiveTileColor = new Color(0.65f, 0.82f, 0.65f);
    
}