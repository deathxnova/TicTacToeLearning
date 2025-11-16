public class LineWinRule : IWinCheckRule
{
    public int A { get; }
    public int B { get; }
    public int C { get; }
    public LineWinRule(int a, int b, int c)
    {
        
        A = a;
        B = b;
        C = c;
    }
    public bool Check(Board board)
    {
        var cells = board.BoardGround;

        char firstCell = cells[A];

        if (firstCell != 'X' && firstCell != 'O')
        {
            return false;
        }
        return firstCell == cells[B] && firstCell == cells[C];
    }
}