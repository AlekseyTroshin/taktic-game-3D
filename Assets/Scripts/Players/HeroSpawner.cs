using UnityEngine;

public class HeroSpawner : MonoBehaviour
{

    [SerializeField] Hero _heroPrefab;

    private Grid _grid;
    private Node _node;
    private Tile _startTile;
    private Vector2Int _startPosition;
    private PlayerManager _playerManager;
    private void Start()
    {
        _startPosition = new Vector2Int(0, 0);
        _grid = FindAnyObjectByType<GridBuilder>().Grid;
        _startTile = _grid.GetTile(_startPosition);
        _node = _startTile.Node;
        _playerManager = FindAnyObjectByType<PlayerManager>();
        CreateHero(_startTile, _node);
        
    }

    private void CreateHero(Tile startTile, Node node)
    {
        Hero hero = Instantiate(_heroPrefab, startTile.transform.position, Quaternion.identity);
        hero.SetPosition(new Vector3(
            startTile.transform.position.x,
            0.75f,
            startTile.transform.position.z
        ), node);

        _playerManager.AddHero(hero);
    }

}