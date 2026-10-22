using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{

    private Tile _startTile;
    private Tile _targetTile;

    private BFS _bfs;
    private List<Node> _pathBfs = new List<Node>();

    private void Start()
    {
        _bfs = new BFS();
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
                    }
                    else if (_startTile == null)
                    {
                        _startTile = tile;
                    }
                    else
                    {
                        _targetTile = tile;
                        _pathBfs = _bfs.FindPath(_startTile.Node, _targetTile.Node);

                        if (_pathBfs == null)
                        {
                            _targetTile = null;
                        }
                        else 
                        {
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
