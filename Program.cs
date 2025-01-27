// Driver class
using Mission4;
Console.WriteLine("Hello, Welcome to Tic-Tac-Toe!");


// TicTacTools tct = new TicTacTools();

string[,] board =
{
    { "X","O","_"},
    { "X","O","_"},
    { "X","O","_"}
};

TicTacTools.PrintBoard(board);
Console.WriteLine(TicTacTools.CheckWinner(board));