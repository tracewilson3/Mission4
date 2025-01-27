using System.Data;
using Mission4;

internal class Program
{
    TicTacTools t = new TicTacTools();
    private static void Main(string[] args)
    {
        // Driver class
        Console.WriteLine("Hello, Welcome to Tic-Tac-Toe!");

        char[,] gameboard = new char[3, 3]
        {
            { '-', '-', '-' }, // First row
            { '-', '-', '-' }, // Second row
            { '-', '-', '-' }  // Third row
        };


        string winner = "";
        int player = 1;

        while (winner is null)
        {
            if (player % 2 == 1)
            {
                int row = 0;
                int col = 0;
                Console.Write("Player X, enter your row (0-2): ");
                row = int.Parse(Console.ReadLine());
                Console.Write("Player X, enter your column (0-2): ");
                col = int.Parse(Console.ReadLine());
                gameboard = UpdateBoard(player, row, col, gameboard);

            }
            else if (player % 2 == 0)
            {
                int row = 0;
                int col = 0;
                Console.Write("Player O, enter your row (0-2): ");
                row = int.Parse(Console.ReadLine());
                Console.Write("Player O, enter your column (0-2): ");
                col = int.Parse(Console.ReadLine());
                gameboard = UpdateBoard(player, row, col, gameboard);

            }

            t.PrintBoard(gameboard);

            //check for winner
            winner = t.CheckWinner(gameboard);

            if (winner is not null)
            {
                Console.WriteLine($"Congratulations Player {winner}, you won!");
            }


            player++;


        }
    }
    public static char[,] UpdateBoard(int player, int row, int col, char[,] gameboard)
    {
        bool updated = false;
        while (!updated)
        {

            // check if spot is already taken
            if (gameboard[row, col] == '-')
            {
                if (player % 2 == 1)
                {
                    gameboard[row, col] = 'X';
                    
                }
                else if (player % 2 == 0)
                {
                    gameboard[row, col] = 'O';
                    
                }
                updated = true;
            }

            else
            {
                Console.WriteLine("That spot is already taken.");
                Console.Write("Enter your column (0-2): ");
                row = int.Parse(Console.ReadLine());
                Console.Write("Enter your column (0-2): ");
                col = int.Parse(Console.ReadLine());
            }
           
        }
        return gameboard;
        
    }

}
