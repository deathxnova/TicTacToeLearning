public class BoardPrinter
{
    private readonly IBoardFormatter _formatter;
    private readonly Board _board;
    public BoardPrinter(IBoardFormatter formatter, Board board)
    {
        _formatter = formatter;
        _board = board;
    }

    public void PrintBoard()
    {
        const int sideLength = 3;
        var cells = _board.BoardGround;

        for (int i = 0; cells.Length > i; i++)
        {
            var boardCell = cells[i];

            if (i > 0 && i % sideLength == 0)
            {
                Console.WriteLine("\n---+---+---");
            }
            Console.Write($" {_formatter.ToSymbol(boardCell)}");
            if ((i + 1) % sideLength != 0)
            {
                Console.Write(" |");
            }
        }
    }
}