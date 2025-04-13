using System;

class Program
{
    static void Main(string[] args)
    {
        /* Added a check to stop the user from recording a completed goal
        *  Added a prompt to inform the user of the status
        */

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
                    Console.Write("Enter a file name (append '.txt'): ");
                    string fileName = Console.ReadLine();
                    using (StreamWriter writer = new StreamWriter(fileName, false))
                    {
                        foreach (var item in goals)
                        {
                            writer.Write($"{item.GetName()}~{item.GetDescription()}~{item.GetPoints()}");
                            if (item.GetType().ToString() == "SimpleGoal")
                            {
                                writer.WriteLine($"~{item.IsComplete()}");
                            }
                            else if (item.GetType().ToString() == "ChecklistGoal")
                            {
                                ChecklistGoal checklist = (ChecklistGoal)item;
                                writer.WriteLine($"~{checklist.GetCompleted()}~{checklist.GetTarget()}~{checklist.GetBonus()}");
                            }
                            else
                            {
                                writer.WriteLine();
                            }
                        }
                        writer.WriteLine($"{totalPoints}");
                    }
                    break;
                case "4":
                    Console.Write("What is the name of the file (incl. extension): ");
                    string file = Console.ReadLine();
                    string[] lines = File.ReadAllLines(file);
                    foreach (var line in lines)
                    {
                        if (!string.IsNullOrEmpty(line) && line.Contains('~'))
                        {
                            string[] components = line.Split("~");
                            string goalName = components[0];
                            string goalDescription = components[1];
                            int goalPoints = int.Parse(components[2]);
                            if (components.Length == 4)
                            {
                                bool isComplete = bool.Parse(components[3]);
                                SimpleGoal retrievedGoal = new(goalName, goalDescription, goalPoints);
                                retrievedGoal.SetIsComplete(isComplete);
                                goals.Add(retrievedGoal);
                            }
                            else if (components.Length == 6)
                            {
                                int completed = int.Parse(components[3]);
                                int target = int.Parse(components[4]);
                                int bonus = int.Parse(components[5]);
                                ChecklistGoal retrievedGoal = new(goalName, goalDescription, goalPoints, target, bonus);
                                retrievedGoal.SetCompleted(completed);
                                goals.Add(retrievedGoal);
                            }
                            else
                            {
                                EternalGoal retrievedGoal = new(goalName, goalDescription, goalPoints);
                                goals.Add(retrievedGoal);
                            }
                        }
                        else
                        {
                            totalPoints = int.Parse(line);
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
                    Console.Write("Select a goal to record: ");
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