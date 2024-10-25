namespace Game;

public class RockPaperScissors
{
    public static void Initialize()
    {
        System.Console.WriteLine("Welcome to rock paper scissors!");
        while (true)
        {
            List<string> Choices = new List<string>();
            Choices.Add("Rock");
            Choices.Add("Paper");
            Choices.Add("Scissors");

            System.Console.WriteLine("Please write rock, paper or scissors and play against the computer!");
            System.Console.WriteLine("Or write done in order to exit");

            string UserInput = Console.ReadLine();
            UserInput = UserInput.ToLower();
            if (UserInput.Contains("done"))
            {
                break;
            }
            if (Validate(UserInput))
            {
                string ComputerInput = Randomized();
                WhoWon(UserInput, ComputerInput);
            }

        }

    }
    public static void WhoWon(string UserInput, string ComputerInput)
    {
        string def = $"You picked {UserInput} and the computer picked {ComputerInput}!";
        if (UserInput == "rock" && ComputerInput == "rock")
        {
            DefaultMessage(UserInput, ComputerInput);
            DrawLine("It's a Draw");
        }
        if (UserInput == "paper" && ComputerInput == "paper")
        {
            DefaultMessage(UserInput, ComputerInput);
            DrawLine("It's a Draw");
        }
        if (UserInput == "scissors" && ComputerInput == "scissors")
        {
            DefaultMessage(UserInput, ComputerInput);
            DrawLine("It's a Draw");
        }

        if (UserInput == "rock" && ComputerInput == "scissors")
        {
            DefaultMessage(UserInput, ComputerInput);
            WinLine("You Won!");
        }
        if (UserInput == "paper" && ComputerInput == "rock")
        {
            DefaultMessage(UserInput, ComputerInput);
            WinLine("You Won!");
        }
        if (UserInput == "scissors" && ComputerInput == "paper")
        {
            DefaultMessage(UserInput, ComputerInput);
            WinLine("You Won!");
        }

        if (UserInput == "rock" && ComputerInput == "paper")
        {
            DefaultMessage(UserInput, ComputerInput);
            LossLine("You Lost!");
        }
        if (UserInput == "paper" && ComputerInput == "scissors")
        {
            DefaultMessage(UserInput, ComputerInput);
            LossLine("You Lost!");
        }

        if (UserInput == "scissors" && ComputerInput == "rock")
        {
            DefaultMessage(UserInput, ComputerInput);
            LossLine("You Lost!");
        }

    }
    public static void DrawLine(string message)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }
    public static void WinLine(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }
    public static void LossLine(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }
    public static void DefaultMessage(string UserInput, string ComputerInput)
    {
        System.Console.WriteLine($"You picked {UserInput} and the computer picked {ComputerInput}!");
    }
    public static string Randomized()
    {
        Random Rand = new Random();
        int Choice = Rand.Next(0, 3);
        string PickedWord = "";

        switch (Choice)
        {
            case 0:
                {
                    PickedWord = "rock";
                    break;
                }
            case 1:
                {
                    PickedWord = "paper";
                    break;
                }
            case 2:
                {
                    PickedWord = "scissors";
                    break;
                }
        }

        return PickedWord;
    }
    public static bool Validate(string input)
    {
        if (OnlyLetter(input) || ValidWords(input))
        {
            return true;
        }
        else
        {
            return false;
        }

    }
    public static bool OnlyLetter(string input)
    {
        return input.All(char.IsLetter);
    }
    public static bool ValidWords(string input)
    {
        if (input == "rock")
        {
            return true;
        }
        if (input == "paper")
        {
            return true;
        }
        if (input == "scissors")
        {
            return true;
        }
        return false;
    }
}
