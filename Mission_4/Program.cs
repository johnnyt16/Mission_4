// See https://aka.ms/new-console-template for more information

internal class Program
{
    public static void Main(string[] args)
    {
        // Initialize
        string Player1_move = "";
        string Player2_move = "";
        
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
        
        // Display Empty Board
        
        Console.WriteLine("Player 1, please select your choice (EXAMPLE: 'A, 3')");
        Player1_move = Console.ReadLine();
        
        // Functionality to send choice to Board Update Function
        
        // Display Updated Board
        
        
    }
}