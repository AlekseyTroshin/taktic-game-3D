using UnityEngine;

public class Tile : MonoBehaviour
{

    [SerializeField] private Vector2Int _gridPosition;
    [SerializeField] private Color _color;

    private MeshRenderer _meshRenderer;
    private Node _node;

    private void Start()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
    }

    public void Initialize(Vector2Int gridPosition, Node node)
    {
        _gridPosition = gridPosition;
        _node = node;
    }

}
