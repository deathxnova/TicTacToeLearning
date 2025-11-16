public class WinChecker : IWinChecker
{
    private readonly List<IWinCheckRule> _rules =
    [
        new LineWinRule(0, 1, 2),
        new LineWinRule(3, 4, 5),
        new LineWinRule(6, 7, 8),
        new LineWinRule(0, 3, 6),
        new LineWinRule(1, 4, 7),
        new LineWinRule(2, 5, 8),
        new LineWinRule(0, 4, 8),
        new LineWinRule(2, 4, 6)
    ];
    public GameState CheckWin(Board board)
    {
        var cells = board.BoardGround;

        foreach (var rule in _rules)
        {
            if (rule.Check(board))
            {
                char winner = cells[rule.A];

                return winner == 'X'
                    ? GameState.XWins
                    : GameState.OWins;
            }
        }

        bool boardFull = cells.All(cellsFilled => cellsFilled == 'X' || cellsFilled == 'O');

        if (boardFull)
        {
            return GameState.Draw;
        }
        return GameState.InProgress;
    }
}