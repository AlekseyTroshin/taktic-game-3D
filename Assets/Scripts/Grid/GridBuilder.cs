using UnityEngine;
using System.Collections.Generic;

public class GridBuilder : MonoBehaviour
{

    [SerializeField] private Tile _tilePrifab;
    [SerializeField] private Transform _tileParent;

    [SerializeField] private int _rows = 5;
    [SerializeField] private int _columns = 5;

    private Grid _grid;
    private List<string> _names = new List<string>() {"A", "B", "C", "D", "E"};


    private void Start()
    {
        _grid = new Grid(_rows, _columns);
        CreateGrid(); 
    }

    private void CreateGrid()
    {
        for (int i = 0; i < _rows; i++)
        {
            for (int j = 0; j < _columns; j++)
            {
                Vector3 tilePosition = new Vector3(i, 0, j);
                Vector2Int gridPosition = new Vector2Int(i, j);
                Node node = new Node(gridPosition, _names[i] + (j + 1));


                Tile tile = Instantiate(_tilePrifab, tilePosition, Quaternion.identity, _tileParent);

                tile.Initialize(node);

                _grid.SetTile(gridPosition, tile);
            }
        }

        _grid.CreateEdge();
    }

}
