using UnityEngine;
using System.Collections.Generic;

public class Node
{

    public Vector2Int NodePosition;
    public List<Node> Neighbours = new List<Node>();

    public Node(Vector2Int nodePosition)
    {
    	NodePosition = nodePosition;
    }

}
