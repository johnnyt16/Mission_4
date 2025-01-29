// See https://aka.ms/new-console-template for more information

internal class Program
{
    public static void Main(string[] args)
    {
        TicTacTools tt = new TicTacTools();
        
        // Initialize
        int Player1_move = 0;
        int Player2_move = 0;
        string[] board = new string[9]; 

        
        // Welcome Message
        Console.WriteLine("Welcome to Tic Tac Toe");
        Console.WriteLine("2 Players Required.");
        
        Console.Write("Generating a game board......");
        Thread.Sleep(300);
        Console.Write(".");
        Thread.Sleep(300);
        Console.Write(".");
        Thread.Sleep(300);
        Console.Write(".");

        tt.PrintBoard(board);

        do
        {
            Console.WriteLine("Player 1, please select your choice (EXAMPLE: 3)");

            do
            {
                Player1_move = Console.ReadLine();

            } while (!tt.Validate(Player1_move, moves));


        };
        
        
        // Functionality to send choice to Board Update Function
        
        // Display Updated Board
        
        Console.WriteLine("Player 2, please select your choice (EXAMPLE: 'A, 3')");
        
        Player2_move = Console.ReadLine();
        
        
    }
}