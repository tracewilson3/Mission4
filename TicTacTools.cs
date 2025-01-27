
namespace Mission4;

public class TicTacTools
{


    public static void PrintBoard(string[,] board)
    {
        int rows = board.GetLength(0);
        int cols = board.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                // Print each cell, replacing null or empty cells with a placeholder like a space
                Console.Write(string.IsNullOrEmpty(board[i, j]) ? "   " : $" {board[i, j]} ");

            // Print a horizontal divider after each row except the last
            if (i < rows - 1)
            {
                Console.WriteLine(new string('-', cols * 4 - 1)); // Adjust width of the divider
            }
        }

                    // Print vertical dividers for the board
                    if (j < cols - 1)
                    {
                        Console.Write("|");
                    }
                }

                Console.WriteLine(); // Move to the next row


                // Print a horizontal divider after each row except the last
                if (i < rows - 1)
                {
                    Console.WriteLine(new string('-', cols * 4 - 1)); // Adjust width of the divider
                }
            }
        }
        public static string CheckWinner(string[,] board)
    {
        int rows = board.GetLength(0);
        int cols = board.GetLength(1);

        // Check rows for a winner
        for (int i = 0; i < rows; i++)
        {
            if (board[i, 0] != "_" && board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
            {
                return board[i, 0]; // Return the winner (X or O)
            }
        }

        // Check columns for a winner
        for (int j = 0; j < cols; j++)
        {
            if (board[0, j] != "_" && board[0, j] == board[1, j] && board[1, j] == board[2, j])
            {
                return board[0, j];
            }
        }

        // Check diagonals for a winner
        if (board[0, 0] != "_" && board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
        {
            return board[0, 0];
        }

        if (board[0, 2] != "_" && board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
        {
            return board[0, 2];
        }

        // If no winner, return "None"
        return "None";
    }
}
    }

