using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("1 Nephi", 3, 6);
        List<Word> wordList = new List<Word>();
        string verse = "Therefore go, my son, and thou shalt be favored of the Lord, because thou hast not murmured.";
        string[] words = verse.Split(" ");
        foreach (var word in words)
        {
            Word temp = new Word(word);
            wordList.Add(temp);
        }
        Scripture scr = new Scripture(reference, wordList);
        Console.WriteLine(scr.GetDisplayText());
        do
        {
            Console.WriteLine("Press Enter to hide words or type quit to exit program: ");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            Console.WriteLine(scr.HideRandomWords(2));
        } while (!scr.isAllHidden());
    }
}