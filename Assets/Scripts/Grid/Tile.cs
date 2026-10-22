using UnityEngine;

public class Tile : MonoBehaviour
{

    [SerializeField] private GridColor _gridColor;

    private MeshRenderer _meshRenderer;
    private Node _node;

    private void Awake()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
    }

    public void Initialize(Node node)
    {
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

    public Node Node
    {
        get { return _node; }
        set { _node = value; }
    }
    
}
