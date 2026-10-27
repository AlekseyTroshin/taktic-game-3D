using UnityEngine;

public class Hero : MonoBehaviour
{

    private Node _node;

    public Node Node
    {
        get { return _node; }
        set { _node = value; }
    }

}