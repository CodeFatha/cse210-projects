using System.Diagnostics;

public class Reflection : Activity
{
    private static string _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    private int _duration;
    private string[] _prompts = [
        "Think of a time when you stood up for someone else",
        "Think of a time when you did something really difficult",
        "Think of a time when you helped someone in need",
        "Think of a time when you did something truly selfless",
        "Think of a time when you called someone and it cheered them up",
        "Think of a time you helped a stranger"
    ];
    private string[] _reflections = [
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    ];

    public Reflection(int duration) : base("Reflection Activity", _description, duration)
    {
        _duration = duration;
    }

    public void PromptUser(int reflection_time)
    {
        Stopwatch timer = new();
        timer.Start();
        Random generator = new();
        List<int> promptIndexes = new();
        List<int> refIndexes = new();
        int index = generator.Next(0, _prompts.Length);
        while (promptIndexes.Contains(index))
        {
            index = generator.Next(0, _prompts.Length);

        }
        promptIndexes.Add(index);

        Console.WriteLine($"==={_prompts[index]}===");
        Console.WriteLine("Press the Enter key when you are ready to continue");
        Console.Read();
        while (timer.Elapsed.Seconds < _duration)
        {
            index = generator.Next(0, _reflections.Length);
            while (refIndexes.Contains(index))
            {
                index = generator.Next(0, _reflections.Length);
            }
            refIndexes.Add(index);
            Console.WriteLine(_reflections[index]);
            Pause(reflection_time, "Reflect");
        }
    }
}