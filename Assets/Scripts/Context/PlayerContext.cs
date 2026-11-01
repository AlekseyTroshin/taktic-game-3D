public class PlayerContext
{

    private Hero _hero;
    private InputController _inputController;

    public PlayerContext(Hero hero, InputController inputController)
    {
        _hero = hero;
        _inputController = inputController;
    }
    
}
