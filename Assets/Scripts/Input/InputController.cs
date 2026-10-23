using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{

    private Tile _startTile;
    private Tile _targetTile;

    private BFS _bfs;
    private List<Node> _pathBfs = new List<Node>();

    private Grid _grid;
    private PathVisualizer _pathVisualizer;

    private void Start()
    {
        _bfs = new BFS();
        _grid = FindAnyObjectByType<GridBuilder>().Grid;
        _pathVisualizer = FindAnyObjectByType<PathVisualizer>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                Tile tile = hit.collider.gameObject.GetComponent<Tile>();

                if (tile != null)
                {
                    if (_startTile != null && _targetTile != null)
                    {
                       
                        _startTile= tile; 
                         Debug.Log(_startTile.Node.Position + " | " + _targetTile.Node.Position);
                        _targetTile= null;
                        _pathBfs = null;
                    }
                    else if (_startTile == null)
                    {
                        _startTile = tile;
                    }
                    else if (_startTile != tile)
                    {
                        _targetTile = tile;
                        _pathBfs = null;
                        _pathBfs = _bfs.FindPath(_startTile.Node, _targetTile.Node);

                        if (_pathBfs == null)
                        {
                            _targetTile = null;
                        }
                        else 
                        {
                            _pathVisualizer.SetPathTiles(_grid, _pathBfs);
                            _pathVisualizer.StartVisualizerPath();
                            foreach(Node node in _pathBfs)
                            {
                                Debug.Log(node.Name);
                            }
                        }
                    }
                }
            }
        }
    }

}
