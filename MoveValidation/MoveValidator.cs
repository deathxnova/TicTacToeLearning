public class MoveValidator : IMoveValidator
{
    private readonly Board _board;

    public MoveValidator(Board board)
    {
        _board = board;
    }

    public (MoveResult result, int validatedIndex) ValidateMove(string userInput)
    {

        var cells = _board.BoardGround;
        const int invalidIndex = -1;
        if (string.IsNullOrWhiteSpace(userInput))
            return (MoveResult.Invalid, invalidIndex);

        if (!int.TryParse(userInput, out int number))
            return (MoveResult.Invalid, invalidIndex);

        if (number < 1 || number > cells.Length)
            return (MoveResult.Invalid, invalidIndex);

        int index = number - 1;

        if (_board.BoardGround[index] == 'X' || _board.BoardGround[index] == 'O')
            return (MoveResult.CellOccupied, invalidIndex);

        return (MoveResult.Valid, index);
    }
}