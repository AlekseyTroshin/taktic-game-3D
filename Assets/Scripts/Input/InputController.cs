using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{

    private Hero _hero;
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
                    Debug.Log("_hero " + _hero);
                    _targetTile = tile;
                    _pathBfs = _bfs.FindPath(_hero.Node, _targetTile.Node);

                    if (_pathBfs == null)
                    {
                        _targetTile = null;
                    }
                    else 
                    {
                        _pathVisualizer.StopPathHighlight();
                        _pathVisualizer.ClearPathTiles();
                        _pathVisualizer.SetPathTiles(_grid, _pathBfs);
                        _pathVisualizer.StartPathHighlight();
                    }
                }
            }
        }
    }

    public void Initialize(Hero hero)
    {
        _hero = hero;
    }

}
