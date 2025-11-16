public class BasicBoardFormatter : IBoardFormatter
{
    public string ToSymbol(char boardCell)
    {
        // If it's X or O, print it
        if (boardCell == 'X' || boardCell == 'O')
            return boardCell.ToString();

        // Otherwise print the number (1–9)
        return boardCell.ToString();
    }

    public ConsoleColor GetColor(char boardCell)
    {
        if (boardCell == 'X')
        {
            return ConsoleColor.Blue;
        }
        if (boardCell == 'O')
        {
            return ConsoleColor.DarkRed;
        }

        return ConsoleColor.DarkGray;
    }
}