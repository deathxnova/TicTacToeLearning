Console.WriteLine("=== Tic Tac Toe ===");
var setup = new GameSetup();
GameConfiguration config = setup.Configure();

while (true)
{
    Console.Clear();

    var game = new Game(config.Player1, config.Player2);
    game.Run();

    Console.Write("\nDo you want to play again? (y/n): ");
    string? answer = Console.ReadLine()?.ToLower();

    if (answer != "y")
    {
        Console.WriteLine("Thanks for playing!");
        break;
    }
}