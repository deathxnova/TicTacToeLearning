public class BasicBoardFormatter : IBoardFormatter
{
    public string ToSymbol(char boardCell)
    {
        return (boardCell == 'X' || boardCell == 'O') ? boardCell.ToString() : "_";
    }

}