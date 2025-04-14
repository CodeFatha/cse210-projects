using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        string date = DateTime.Now.ToString("dd MMM yyyy");
        Activity swimming = new Swimming(date, 15, 4);
        Activity running = new Running(date, 40, 4);
        Activity cycling = new Cycling(date, 30, 12);

        List<Activity> activities = [swimming, running, cycling];

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary(activity.GetType().ToString()));
        }
    }
}