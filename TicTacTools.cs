namespace Mission4;

public class TicTacTools
{
   public static void PrintBoard(string[,] board)
      {
        int rows = board.GetLength(0);
        int cols = board.GetLength(1);

grant's-branch
        for (int i = 0; i < rows; i++)
          {
            for (int j = 0; j < cols; j++)
               {
                 // Print each cell, replacing null or empty cells with a placeholder like a space
                    Console.Write(string.IsNullOrEmpty(board[i, j]) ? "   " : $" {board[i, j]} ");

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
    }
