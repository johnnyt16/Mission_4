char[,] board = new char[3, 3];

//Print the Board

public static void PrintBoard(char[,] board)
{
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            Console.Write(board[i, j] + " ");
        }
        Console.WriteLine();
    }
}

//Check for a winner
public static bool CheckWinner(char[,] board)
{
    // Check rows, columns, and diagonals for a win
    for (int i = 0; i < 3; i++)
    {
        if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2] && board[i, 0] != '\0')
            return true;
        if (board[0, i] == board[1, i] && board[1, i] == board[2, i] && board[0, i] != '\0')
            return true;
    }
    if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != '\0')
        return true;
    if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[0, 2] != '\0')
        return true;
    return false;
}