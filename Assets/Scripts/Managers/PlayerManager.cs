using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    
    [SerializeField] private InputController _inputControllerPrefab;
    private Dictionary<int, PlayerContext> _players;
    private int amountIdPlayer = 1;

    public void Awake()
    {
        _players = new Dictionary<int, PlayerContext>();
    }

    public void AddHero(Hero hero)
    {
        hero.PlayerId = amountIdPlayer;
        InputController inputController = Instantiate(
            _inputControllerPrefab, 
            Vector3.zero, 
            Quaternion.identity
        );

        inputController.Initialize(hero);

        PlayerContext playerContext = new PlayerContext(hero, inputController);

        _players.Add(amountIdPlayer, playerContext);
        amountIdPlayer++;

    }

}
