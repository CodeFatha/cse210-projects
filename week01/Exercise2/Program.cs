using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        int grade = int.Parse(Console.ReadLine());
        string letter;

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (grade % 10 >= 7 && letter != "A" && letter != "F")
        {
            letter = letter + "+";
        }
        else if (grade % 10 <= 3 && letter != "A" && letter != "F")
        {
            letter = letter + "-";
        }

        Console.WriteLine($"You got a {letter} for this module");

        if (grade >= 70)
        {
            Console.WriteLine("You passed, congratulations!");
        }
    }
}