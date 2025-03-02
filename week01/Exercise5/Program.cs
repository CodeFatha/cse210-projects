using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();
        DisplayResult();
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program.");
    }
    static string PromptUserName()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Enter your favourite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }
    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult()
    {
        string name = PromptUserName();
        int square = SquareNumber(PromptUserNumber());

        Console.WriteLine($"Your name is {name} and your number squared gives {square}");
    }
}