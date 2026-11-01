using UnityEngine;

public class Hero : MonoBehaviour
{

    private Node _node;

    public Node Node
    {
        get { return _node; }
        set { _node = value; }
    }

    public void SetPosition(Vector3 position, Node node)
    {
        transform.position = position;
        _node = node;
    }

}