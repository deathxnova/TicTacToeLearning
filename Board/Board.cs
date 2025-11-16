public class Board
{

    public char[] BoardGround { get; }

    public Board()
    {
        BoardGround =
        [
            '1','2','3',
            '4','5','6',
            '7','8','9'
        ];
    }

    public MoveResult ApplyMove(int playerMove, char playerSymbol)
    {
        var cellLength = BoardGround.Length - 1;
        if (playerMove < 0 || playerMove > cellLength)
        {
            return MoveResult.Invalid;
        }
        if (BoardGround[playerMove] == 'X' || BoardGround[playerMove] == 'O')
        {
            return MoveResult.CellOccupied;
        }
        BoardGround[playerMove] = playerSymbol;
        return MoveResult.Valid;
    }

}