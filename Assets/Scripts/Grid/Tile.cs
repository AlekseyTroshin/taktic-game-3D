using UnityEngine;

public class Tile : MonoBehaviour
{

    [SerializeField] private Vector2Int _gridPosition;

    [SerializeField] private GridColor _gridColor;

    private MeshRenderer _meshRenderer;
    private Node _node;

    private void Awake()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
    }

    public void Initialize(Vector2Int gridPosition, Node node)
    {
        _gridPosition = gridPosition;
        _node = node;
    }

    public void SetCalmColor()
    {
        _meshRenderer.material.color = _gridColor.CalmTileColor;
    }

    public void SetActiveColor()
    {
        _meshRenderer.material.color = _gridColor.ActiveTileColor;
    }

}
