using UnityEngine;
using System.Collections.Generic;
using System.Collections;
public class PathVisualizer : MonoBehaviour
{
    
    private List<Node> _pathTiles;
    private Grid _grid;
    private Coroutine _coroutineHighlight;

    public List<Node> PathTiles 
    {
        get { return _pathTiles; }
    }

    public void SetPathTiles(Grid grid, List<Node> pathTiles)
    {
        _grid = grid;
        _pathTiles = pathTiles;
    }

    public void StartPathHighlight()
    {
        _coroutineHighlight = StartCoroutine(HighlightPathRoutine());
    }

    public void StopPathHighlight()
    {
        if (_coroutineHighlight != null)
        {
            StopCoroutine(_coroutineHighlight);
            _coroutineHighlight = null;
        }
    }

    public void ClearPathTiles()
    {
        if (_pathTiles != null && _grid != null)
        {
            int count = _pathTiles.Count;

            for (int i = 0; i < count; i++)
            {
                Tile tile = _grid.GetTile(_pathTiles[i].Position);
                tile.SetCalmColor();
            }

            _pathTiles.Clear();
        }
    }

    private IEnumerator HighlightPathRoutine()
    {
        int count = _pathTiles.Count;

        for (int i = 0; i < count; i++)
        {
            Tile tile = _grid.GetTile(_pathTiles[i].Position);
            tile.SetActiveColor();
            yield return new WaitForSeconds(0.2f);
        }

        _coroutineHighlight = null;
    }

}