// See https://aka.ms/new-console-template for more information

internal class Program
{
    public static void Main(string[] args)
    {
        // Initialize Tic-Tac-Toe helper class
        TicTacTools tt = new TicTacTools();
        // Game board as a 1D array (matching TicTacTools)
        string[] board = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        // Welcome Message
        Console.WriteLine("Welcome to Tic Tac Toe!");
        Console.WriteLine("2 Players Required.\n");
        Console.Write("Generating a game board");
        Thread.Sleep(300); Console.Write(".");
        Thread.Sleep(300); Console.Write(".");
        Thread.Sleep(300); Console.Write(".\n\n");
        // Display Initial Board
        TicTacTools.PrintBoard(board);
        string currentPlayer = "X";
        bool gameWon = false;
        while (!gameWon)
        {
            Console.WriteLine($"Player {currentPlayer}, please select a number (1-9): ");
            string playerMove = Console.ReadLine();
            // Validate Move
            if (!IsValidMove(board, playerMove))
            {
                Console.WriteLine("Invalid move. Try again.");
                continue;
            }
            // Update Board
            board[int.Parse(playerMove) - 1] = currentPlayer;
            // Display Updated Board
            TicTacTools.PrintBoard(board);
            // Check for Winner
            string winner = TicTacTools.CheckWinner(board);
            if (winner == "X" || winner == "O")
            {
                Console.WriteLine($"Player {winner} wins!");
                gameWon = true;
            }
            else if (winner == "Tie")
            {
                Console.WriteLine("It's a tie!");
                gameWon = true;
            }
            // Switch Players
            currentPlayer = (currentPlayer == "X") ? "O" : "X";
        }
    }
    // Method to Validate Player Move
    private static bool IsValidMove(string[] board, string move)
    {
        return int.TryParse(move, out int index) && index >= 1 && index <= 9 && board[index - 1] != "X" && board[index - 1] != "O";
    }
}