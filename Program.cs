using Game;
public class Program
{
    private static void Main(string[] args)
    {
        menu();
        gamePicked();
    }
    private static void menu()
    {
        System.Console.WriteLine("_____________GAME_MENU_______________");
        System.Console.WriteLine("|1: Rock, Paper, Scissors           |");
        System.Console.WriteLine("|2: Tic-Tac-Toe                     |");
        System.Console.WriteLine("_____________________________________");
    }
    private static void gamePicked()
    {
        string input = Console.ReadLine();
        int choice = int.Parse(input);
        if (choice == 1)
        {
            RockPaperScissors.Initialize();
        }
        if (choice == 2)
        {

        }
        else
        {
            Environment.Exit(1);
        }
    }
}