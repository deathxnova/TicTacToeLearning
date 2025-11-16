var setup = new GameSetup();
GameConfiguration config = setup.Configure();

bool play = true;

while (play)
{
    Console.Clear();
    Console.WriteLine("=== Tic Tac Toe ===");

    var game = new Game(config.Player1, config.Player2);
    game.Run();

    bool chosen = false;
    while (!chosen)
    {
        Console.Write("\nDo you want to play again? (y/n): ");
        string? answer = Console.ReadLine()?.Trim().ToLower();

        if (string.IsNullOrWhiteSpace(answer))
        {
            Console.WriteLine("Choice cannot be empty!");
            continue;
        }

        if (answer == "y")
        {
            chosen = true;
        }

        if (answer == "n")
        {
            Console.WriteLine("Thanks for playing!");
            chosen = true;
            play = false;
            Console.ReadKey();
        }

        Console.WriteLine("Please choose Y(yes) or N(no).");
    }
}