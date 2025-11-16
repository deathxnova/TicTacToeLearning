public class HumanPlayer(string name, char symbol) : IPlayer
{
    public string Name { get; } = name;
    public char Symbol { get; } = symbol;

    public string GetMove()
    {
        Console.WriteLine($"{Name} your symbol is {Symbol}, choose a move.");
        return Console.ReadLine() ?? string.Empty;
    }
}