public class GameSetup
{
    public GameConfiguration Configure()
    {
        Console.Write("Player 1, enter your name: ");
        string name1 = Console.ReadLine() ?? "Player 1";

        char symbol1;
        while (true)
        {
            Console.Write($"{name1}, choose your symbol (X or O): ");
            string? s = Console.ReadLine()?.ToUpper();

            if (s == "X" || s == "O")
            {
                symbol1 = s[0];
                break;
            }

            Console.WriteLine("Invalid symbol. Please choose X or O.");
        }

        char symbol2 = symbol1 == 'X' ? 'O' : 'X';

        Console.Write("Player 2, enter your name: ");
        string name2 = Console.ReadLine() ?? "Player 2";

        IPlayer player1 = new HumanPlayer(name1, symbol1);
        IPlayer player2 = new HumanPlayer(name2, symbol2);

        return new GameConfiguration(player1, player2);
    }
}