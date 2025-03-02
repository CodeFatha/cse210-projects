using System;

class Program
{
    static void Main(string[] args)
    {
        int input = 1;
        List<int> numbers = new List<int>();

        while (input != 0)
        {
            Console.Write("Enter a number or zero to exit: ");
            input = int.Parse(Console.ReadLine());
            if (input == 0)
            {
                continue;
            }
            else
            {
                numbers.Add(input);
            }
        }

        Console.WriteLine($"The sum is {numbers.Sum()}");
        Console.WriteLine($"The average is {numbers.Average()}");
        Console.WriteLine($"The largest number is {numbers.Max()}");
        Console.WriteLine($"The smallest positive number is {numbers.Where(n => n > 0).Min()}");
        numbers.Sort();
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}