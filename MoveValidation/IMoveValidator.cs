public interface IMoveValidator
{
    (MoveResult result, int validatedIndex) ValidateMove(string userInput);
}