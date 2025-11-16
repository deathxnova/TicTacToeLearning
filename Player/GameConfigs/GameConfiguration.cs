public class GameConfiguration
{
    public IPlayer Player1 { get; }
    public IPlayer Player2 { get; }

    public GameConfiguration(IPlayer player1, IPlayer player2)
    {
        Player1 = player1;
        Player2 = player2;
    }
}