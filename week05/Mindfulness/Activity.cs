using System.Text;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;


    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public string WelcomeMessage()
    {
        return $"Welcome to the {_name} \n{_description}";
    }

    public string GoodbyeMessage()
    {
        return $"Good job! \nYou completed the {_name} in {_duration} seconds";
    }

    public string PrepareMessage()
    {
        return $"Get ready to begin";
    }

    public void Pause(int seconds, string text)
    {
        StringBuilder sb = new();
        int count = 0;
        while (count < seconds * 3)
        {
            if (sb.Length <= 2)
            {
                sb.Append('.');
                Console.SetCursorPosition(text.Count(), Console.CursorTop);
                Console.Write(new string(' ', Console.CursorTop));
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write(new string($"{text}{sb}"), Console.CursorTop);
            }
            else
            {
                sb.Clear();
                Console.SetCursorPosition(text.Count(), Console.CursorTop);
                Console.Write(new string(' ', Console.CursorTop));
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write(new string($"{text}{sb}"), Console.CursorTop);
            }
            Thread.Sleep(333);
            count++;
        }
        Console.SetCursorPosition(0, Console.CursorTop);
        Console.Write(new string(' ', Console.WindowWidth));
        Console.SetCursorPosition(0, Console.CursorTop);
    }

    public void CountDown(int sec)
    {
        for (int i = 0; i < sec; i++)
        {
            string text = $"Starts in {sec - i}";
            Console.Write(text);
            Console.SetCursorPosition(0, Console.CursorTop);
            Thread.Sleep(1000);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop);
        }
    }

    public void Spinner(string text)
    {
        string blade = "/-|\\";
        Console.Write(text);
        for (int i = 0; i < 15; i++)
        {
            Console.Write(blade[i % blade.Length]);
            Thread.Sleep(333);
            Console.Write("\b");
        }
    }
}