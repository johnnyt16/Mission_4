using System;

public class TicTacTools
{
    // Method to print the board
    public void PrintBoard(string[] board)
    {
        Console.Clear();
        Console.WriteLine("Tic-Tac-Toe Game");
        Console.WriteLine();

        Console.WriteLine(" {0} | {1} | {2} ", board[0], board[1], board[2]);
        Console.WriteLine("---+---+---");
        Console.WriteLine(" {0} | {1} | {2} ", board[3], board[4], board[5]);
        Console.WriteLine("---+---+---");
        Console.WriteLine(" {0} | {1} | {2} ", board[6], board[7], board[8]);
        Console.WriteLine();
    }

    // Method to check if there is a winner
    public static string CheckWinner(string[] board)
    {
        // Define winning combinations
        int[,] winningCombinations = new int[,]
        {
            {0, 1, 2}, {3, 4, 5}, {6, 7, 8}, // Rows
            {0, 3, 6}, {1, 4, 7}, {2, 5, 8}, // Columns
            {0, 4, 8}, {2, 4, 6}  // Diagonals
        };

        // Check for a winner
        for (int i = 0; i < winningCombinations.GetLength(0); i++)
        {
            if (board[winningCombinations[i, 0]] == board[winningCombinations[i, 1]] &&
                board[winningCombinations[i, 1]] == board[winningCombinations[i, 2]])
            {
                return board[winningCombinations[i, 0]]; // Return the winner ("X" or "O")
            }
        }

        // Check for a tie (if no numbers remain on the board)
        foreach (string spot in board)
        {
            if (spot != "X" && spot != "O")
            {
                return ""; // No winner yet
            }
        }

        return "TIE"; // If the board is full and no winner, it's a tie
    }
}
