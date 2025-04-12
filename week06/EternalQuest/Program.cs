using System;

class Program
{
    static void Main(string[] args)
    {
        bool isRun = true;
        List<Goal> goals = new List<Goal>();
        int totalPoints = 0;
        do
        {
            Console.WriteLine($"\nYou have {totalPoints} points\n");
            Console.WriteLine("Menu Options:\n1. Create Goal \n2. List Goals \n3. Save Goals \n4. Load Goals \n5. Record Event \n6. Exit");
            Console.Write("Select an option to start: ");
            string response = Console.ReadLine();
            switch (response)
            {
                case "1":
                    Console.WriteLine("These are the types of goals: \n1. Simple Goal \n2. Eternal Goal \n3. Checklist Goal");
                    Console.Write("Which type of goal would you like to create: ");
                    response = Console.ReadLine();
                    Console.Write("What is the name if your goal: ");
                    string name = Console.ReadLine();
                    Console.Write("Give a short description: ");
                    string description = Console.ReadLine();
                    Console.Write("How many points is this worth: ");
                    int points = int.Parse(Console.ReadLine());
                    Goal goal;
                    if (response == "1")
                    {
                        goal = new SimpleGoal(name, description, points);
                    }
                    else if (response == "2")
                    {
                        goal = new EternalGoal(name, description, points);
                    }
                    else if (response == "3")
                    {
                        Console.Write("How many times do you want to do this: ");
                        int target = int.Parse(Console.ReadLine());
                        Console.Write("How many points will your bonus be: ");
                        int bonus = int.Parse(Console.ReadLine());

                        goal = new ChecklistGoal(name, description, points, target, bonus);
                    }
                    else
                    {
                        Console.WriteLine("Cannot understand your input");
                        continue;
                    }
                    goals.Add(goal);
                    break;
                case "2":
                    foreach (var item in goals)
                    {
                        string check = item.IsComplete() ? "[x]" : "[ ]";
                        Console.WriteLine($"{check} {item.GetFormattedString()}");
                    }
                    break;
                case "3":
                    Console.Write("Enter a file name: ");
                    string fileName = Console.ReadLine();
                    using (StreamWriter writer = new StreamWriter(fileName, false))
                    {
                        foreach (var item in goals)
                        {
                            writer.WriteLine($"{item.GetName()}~{item.GetDescription()}~{item.GetPoints()}~{item.IsComplete()}");
                        }
                    }
                    break;
                case "4":
                    Console.Write("What is the name of the file (incl extension): ");
                    string file = Console.ReadLine();
                    string[] lines = File.ReadAllLines(file);
                    foreach (var line in lines)
                    {
                        if (!string.IsNullOrEmpty(line))
                        {
                            string[] component = line.Split("~");
                            string goalName = component[0];
                            string goalDescription = component[1];
                            string goalPoints = component[2];
                            // Goal myGoal = new(goalName, goalDescription, goalPoints);
                            // goals.Add(myGoal);
                        }
                    }
                    break;
                case "5":
                    Console.WriteLine("Here is a list of goals");
                    int count = 1;
                    foreach (var item in goals)
                    {
                        Console.WriteLine($"{count}. {item.GetName()}");
                        count++;
                    }
                    Console.Write("Select a goal to record:");
                    int selection = int.Parse(Console.ReadLine());
                    Goal currentGoal = goals[selection - 1];
                    if (currentGoal.IsComplete())
                    {
                        Console.WriteLine("Sorry!, this goal has already been compeleted");
                        continue;
                    }
                    else
                    {
                        currentGoal.RecordEvent();
                        totalPoints += currentGoal.GetPoints();
                        string type = currentGoal.GetType().ToString();
                        if (type == "ChecklistGoal" && currentGoal.IsComplete())
                        {
                            ChecklistGoal current = (ChecklistGoal)currentGoal;
                            int bonus = current.GetBonus();
                            totalPoints += bonus;
                            Console.WriteLine($"Congrats! You earned {bonus} bonus points");
                        }
                    }
                    break;
                case "6":
                    Console.WriteLine("Goodbye!");
                    isRun = false;
                    break;
                default:
                    Console.WriteLine("Cannot understand the input");
                    continue;
            }
        } while (isRun);
    }
}