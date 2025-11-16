IBoardFormatter formatter = new BasicBoardFormatter();
var boardGround = new Board();
var printBoard = new BoardPrinter(formatter, boardGround);
printBoard.PrintBoard();
Console.ReadKey();