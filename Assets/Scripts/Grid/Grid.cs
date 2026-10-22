using UnityEngine;

public class Grid
{
    
    private Tile[,] _tiles;
    private int _rows;
    private int _columns;


    public Grid(int rows, int columns)
    {
    	_rows = rows;
    	_columns = columns;
    	_tiles = new Tile[rows, columns];

        // for (int i = 0; i < rows; i++)
        //     for (int j = 0; j < columns; j++)
        //     {
        //         _tiles[i, j].Node = new Node(new Vector2Int(i, j));
        //     }
    }

    public void SetTile(Vector2Int tilePositon, Tile tile)
    {
    	_tiles[tilePositon.x, tilePositon.y] = tile;
    }

    public Tile GetTile(Vector2Int tilePositon)
    {
    	return _tiles[tilePositon.x, tilePositon.y];
    }

    public void CreateEdge()
    {

    	for (int i = 0; i < _rows; i++)
    	{
    		for (int j = 0; j < _columns; j++)
    		{
    			Node node = _tiles[i, j].Node;

    			node.Neighbours.Clear();

    			if (j + 1 < _columns) 
    				node.Neighbours.Add(_tiles[i, j + 1].Node);
    			if (j - 1 >= 0)
    				node.Neighbours.Add(_tiles[i, j - 1].Node);
    			if (i + 1 < _rows)
    				node.Neighbours.Add(_tiles[i + 1, j].Node);
    			if (i - 1 >= 0)
    				node.Neighbours.Add(_tiles[i - 1, j].Node);

    		}
    	}

        // for (int i = 0; i < _rows; i++)
    	// {
    	// 	for (int j = 0; j < _columns; j++)
    	// 	{
        //         Node node = _tiles[i, j].Node;
        //         Debug.Log(node.Position.x + " " + node.Position.y + " : ");
        //         foreach (Node n in node.Neighbours)
        //         {
        //             Console.Write(n.Position.x + " " + n.Position.y + " | ");
        //         }
        //         Console.WriteLine();
        //     }
            
        // }

    }
    
}