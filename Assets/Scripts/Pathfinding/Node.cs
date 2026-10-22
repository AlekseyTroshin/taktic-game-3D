using UnityEngine;
using System.Collections.Generic;

public class Node
{

	public string Name;
    public Vector2Int Position;
    public List<Node> Neighbours = new List<Node>();

    public Node(Vector2Int position, string name)
    {
    	Position = position;
    	Name = name;
    }

}
