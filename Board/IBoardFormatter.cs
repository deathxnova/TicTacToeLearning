public interface IBoardFormatter
{
    string ToSymbol(char boardCell);
    ConsoleColor GetColor(char boardCell);
}