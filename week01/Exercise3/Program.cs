using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        bool correct = false;
        Random ranGen = new Random();
        int winningNumber = ranGen.Next(1, 11);
        int guesses = 0;
        bool playAgain = false;
        do
        {
            Console.Write("Guess a number between 1 and 10: ");
            int guess = int.Parse(Console.ReadLine());
            guesses++;

            if (guess == winningNumber)
            {
                correct = true;
                Console.WriteLine($"Awesome! You got it right in {guesses} guesses.");
                Console.Write("Do you want to paly again (Y/N): ");
                string response = Console.ReadLine();
                if (response.ToLower() == "y")
                {
                    playAgain = true;
                    winningNumber = ranGen.Next(1, 11);
                    guesses = 0;
                }
            }
            else if (guess > winningNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Higher");
            }


        } while (!correct || playAgain);

    }
}