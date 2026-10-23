using UnityEngine;
using System.Collections.Generic;
using System.Collections;
public class PathVisualizer : MonoBehaviour
{
    
    private List<Node> _pathTiles;
    private Grid _grid;

    public List<Node> PathTiles 
    {
        get { return _pathTiles; }
    }

    public void SetPathTiles(Grid grid, List<Node> pathTiles)
    {
        _grid = grid;
        _pathTiles = pathTiles;
    }

    public void StartVisualizerPath()
    {
        StartCoroutine(StartVisualizer());
    }

    private IEnumerator StartVisualizer()
    {
        for (int i = 0; i < _pathTiles.Count; i++)
        {
            Tile tile = _grid.GetTile(_pathTiles[i].Position);
            tile.SetActiveColor();
            yield return new WaitForSeconds(0.2f);
        }
    }

}