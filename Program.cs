using System.Data;
using Mission4;

internal class Program
{
    
    private static void Main(string[] args)
    {
        // Driver class
        Console.WriteLine("Hello, Welcome to Tic-Tac-Toe!");

        string[,] gameboard = 
        {
            { "_", "_", "_" }, // First row
            { "_", "_", "_" }, // Second row
            { "_", "_", "_" }  // Third row
        };


        string winner = "";
        int player = 1;
        

        while (winner=="" && player<=9)
        {
            if (player % 2 == 1)
            {
                bool isValid = false;

                while (!isValid)
                {
                    Console.Write("Enter your row (0-2): ");
                    string rowInput = Console.ReadLine();
                    Console.Write("Enter your column (0-2): ");
                    string colInput = Console.ReadLine();

                    if (int.TryParse(rowInput, out int row) && int.TryParse(colInput, out int col))
                    {
                        if (row >= 0 && row <= 2 && col >= 0 && col <= 2)
                        {
                            isValid = true; // Valid input
                        }
                        else
                        {
                            Console.WriteLine("That spot is out of range. Please try again.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter numeric values between 0 and 2.");
                    }
                }
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

            TicTacTools.PrintBoard(gameboard);

            //check for winner
            if (TicTacTools.CheckWinner(gameboard)!="")
            {
                winner = TicTacTools.CheckWinner(gameboard);
                Console.WriteLine($"Congratulations Player {winner}, you won!");
            }

            // Check for a tie after 9 turns
            if (player == 9 && winner == "")
            {
                Console.WriteLine("It's a tie!");
                break; // Exit the loop if it's a tie
            }

            
            player++;


        }
    }
    public static string[,] UpdateBoard(int player, int row, int col, string[,] gameboard)
    {
        bool updated = false;
        while (!updated)
        {

            // check if spot is already taken
            if (gameboard[row, col] == "_")
            {
                if (player % 2 == 1)
                {
                    gameboard[row, col] = "X";
                    
                }
                else if (player % 2 == 0)
                {
                    gameboard[row, col] = "O";
                    
                }
                updated = true;
            }

            else
            {
                Console.WriteLine("That spot is already taken.");
                Console.Write("Enter your row (0-2): ");
                row = int.Parse(Console.ReadLine());
                
                    
                Console.Write("Enter your column (0-2): ");
                col = int.Parse(Console.ReadLine());
                /*if (!int.TryParse(row)|(!int.TryParse(col)))
                {
                    Console.WriteLine("Please enter a number between 0 and 2.");
                }*/
                if ((row < 0 || row > 2)|| (col < 0 || col > 2))
                {
                    Console.WriteLine("That spot is out of range.");
                }
            }
           
        }
        return gameboard;
        
    }

}
