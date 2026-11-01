using UnityEngine;
using UnityEngine.Rendering;

public class Hero : MonoBehaviour
{

    private Node _node;
    private int _playerId;

    public Node Node
    {
        get { return _node; }
        set { _node = value; }
    }

    public int PlayerId
    {
        get { return _playerId; }
        set { _playerId = value; }
    }

    public void SetPosition(Vector3 position, Node node)
    {
        transform.position = position;
        _node = node;
    }

}