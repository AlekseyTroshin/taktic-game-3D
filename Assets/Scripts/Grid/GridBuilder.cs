using UnityEngine;

public class GridBuilder : MonoBehaviour
{

    [SerializeField] private Tile _tilePrifab;
    [SerializeField] private Transform _tileParent;

    [SerializeField] private int _rows = 5;
    [SerializeField] private int _columns = 5;


    private void Start()
    {
        CreateGrid();
    }

    private void CreateGrid()
    {
        for (int i = 0; i < _rows; i++)
        {
            for (int j = 0; j < _columns; j++)
            {
                Vector3 tilePosition = new Vector3(i, 0, j);

                Tile tile = Instantiate(_tilePrifab, tilePosition, Quaternion.identity, _tileParent);
            }
        }
    }

}
