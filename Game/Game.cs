public class Game
{
    private readonly IPlayer _player1;
    private readonly IPlayer _player2;

    private IPlayer _currentPlayer;

    private readonly Board _board;
    private readonly MoveValidator _validator;
    private readonly BoardPrinter _printer;
    private readonly WinChecker _winChecker;

    public Game(IPlayer player1, IPlayer player2)
    {
        _player1 = player1;
        _player2 = player2;
        _currentPlayer = _player1.Symbol == 'X' ? _player1 : _player2;

        _board = new Board();
        _validator = new MoveValidator(_board);
        _printer = new BoardPrinter(new BasicBoardFormatter(), _board);
        _winChecker = new WinChecker();
    }

    public void Run()
    {
        while (true)
        {
            Console.Clear();
            _printer.PrintBoard();
            Console.WriteLine();
            Console.WriteLine($"{_currentPlayer.Name}'s turn ({_currentPlayer.Symbol})");

            string input = _currentPlayer.GetMove();
            var (result, index) = _validator.ValidateMove(input);

            if (result == MoveResult.Invalid)
            {
                Console.WriteLine("Invalid input. Please enter a number from 1 to 9.");
                Console.ReadKey();
                continue;
            }

            if (result == MoveResult.CellOccupied)
            {
                Console.WriteLine("That cell is already taken. Choose another.");
                Console.ReadKey();
                continue;
            }

            _board.ApplyMove(index, _currentPlayer.Symbol);

            GameState state = _winChecker.CheckWin(_board);

            if (state != GameState.InProgress)
            {
                Console.Clear();
                _printer.PrintBoard();
                Console.WriteLine();

                if (state == GameState.XWins)
                    Console.WriteLine($"X wins!");

                else if (state == GameState.OWins)
                    Console.WriteLine($"O wins!");

                else if (state == GameState.Draw)
                    Console.WriteLine("It's a draw!");

                break;
            }

            _currentPlayer = _currentPlayer == _player1 ? _player2 : _player1;
        }

        Console.WriteLine("Game over.");
    }
}