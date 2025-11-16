public interface IPlayer
{
    string Name { get; }
    char Symbol { get; }
    string GetMove();
}