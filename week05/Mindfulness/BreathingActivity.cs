using System.Diagnostics;

public class BreathingActivity : Activity
{
    private static string _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    private int _duration;

    public BreathingActivity(int duration) : base("Breathing Activity", _description, duration)
    {
        _duration = duration;
    }

    public void Excercise()
    {
        Stopwatch timer = new();
        timer.Start();
        while (timer.Elapsed.TotalSeconds < _duration)
        {
            Pause(5, "Breathe In");
            Pause(5, "Breathe Out");
        }
    }
}