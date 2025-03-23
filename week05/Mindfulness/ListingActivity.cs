using System.Diagnostics;

public class ListActivity : Activity
{
    private static string _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    private int _duration;
    private string[] _prompts = [
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    ];
    public ListActivity(int duration) : base("List Activity", _description, duration)
    {
        _duration = duration;
    }

    public string PickPrompt()
    {
        Random random = new();
        List<int> indexes = new();

        int index = random.Next(0, _prompts.Length);
        if (indexes.Contains(index))
        {
            index = random.Next(0, _prompts.Length);
        }
        indexes.Add(index);

        return _prompts[index];
    }

    public void ListStuff()
    {
        Stopwatch sw = new();
        sw.Start();
        List<string> entries = new();

        while (sw.Elapsed.Seconds < _duration)
        {
            string entry = Console.ReadLine();
            entries.Add(entry);
        }

        Console.WriteLine($"You have listed {entries.Count} items");
    }
}