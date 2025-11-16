public interface IWinCheckRule
{
    bool Check(Board board);
    int A { get; }
    int B { get; }
    int C { get; }
}