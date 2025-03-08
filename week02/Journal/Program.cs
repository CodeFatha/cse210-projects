using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string _selection = "";
        string _question;
        string _response;
        Journal _journal = new Journal();

        while (_selection != "5")
        {
            Console.WriteLine("Please select one of the following choices\n"
                + "1. Write \n2. Display \n3. Load \n4. Save \n5. Quit \n6. Delete Entry\n"
            );

            Console.Write("What would you like to do? ");
            _selection = Console.ReadLine();

            if (_selection == "1")
            {
                Prompts prompts = new Prompts();
                Entry _entry = new Entry();
                _question = prompts.PickRandomQuestion();
                Console.Write(_question);
                _response = Console.ReadLine();
                _entry._date = DateTime.Now.ToShortDateString();
                _entry._prompt = _question;
                _entry._response = _response;
                _journal.AddEntry(_entry);

            }
            else if (_selection == "2")
            {
                _journal.DisplayEntries();
            }
            else if (_selection == "3")
            {
                Console.Write("Enter a file name (include extension .txt): ");
                string fileName = Console.ReadLine();
                _journal.LoadJournal(fileName);
                Console.WriteLine($"{fileName} was successfully retrieved\n");
            }
            else if (_selection == "4")
            {
                Console.Write("Enter a file name (include extension .txt): ");
                string fileName = Console.ReadLine();
                _journal.SaveJournal(fileName);
            }
            else if (_selection == "5")
            {
                Console.WriteLine("Goodbye!");
                continue;
            }
            else if (_selection == "6")
            {
                int maximum = _journal._entries.Count;
                Console.Write($"Enter the entry number (Betwwen 1 and {maximum}): ");
                int response = int.Parse(Console.ReadLine());
                if (response > 0 && response <= maximum)
                {
                    _journal.DeleteEntry(response - 1);
                }
                else
                {
                    Console.WriteLine("No such entry exists");
                }
            }
            else
            {
                Console.WriteLine("Sorry, I cannot understand the input");
            }
        }
    }
}