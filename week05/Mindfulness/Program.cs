using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Menu Options\n  1. Start breathing activity\n  2. Start reflection activity\n  3. Start listing activity\n  4. Quit");
        Console.Write("Select a choice from the menu: ");
        string response = Console.ReadLine();

        switch (response)
        {
            case "1":
                Console.Write("How many seconds would you want this activity to run: ");
                int duration = int.Parse(Console.ReadLine());
                BreathingActivity ba = new(duration);
                Console.WriteLine(ba.WelcomeMessage());
                ba.Spinner("Getting started...");
                ba.Excercise();
                Console.WriteLine(ba.GoodbyeMessage());
                break;
            case "2":
                Console.Write("How many seconds would you want this activity to run: ");
                int seconds = int.Parse(Console.ReadLine());
                Reflection reflection = new(seconds);
                Console.WriteLine(reflection.WelcomeMessage());
                reflection.PromptUser(seconds / 4);
                Console.WriteLine(reflection.GoodbyeMessage());
                break;
            case "3":
                Console.Write("How many seconds would you want this activity to run: ");
                int time = int.Parse(Console.ReadLine());
                ListActivity la = new(time);
                Console.WriteLine($"{la.WelcomeMessage()}");
                Console.WriteLine(la.PickPrompt());
                la.CountDown(5);
                la.ListStuff();
                Console.WriteLine(la.GoodbyeMessage());
                break;
            case "4":
                Console.WriteLine("Goodbye!");
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Sorry, I cannot understand your input");
                break;
        }

    }
}