public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override string GetFormattedString()
    {
        return $"{GetName()} ({GetDescription()})";
    }
    public override bool IsComplete()
    {
        return false;
    }

    public override void RecordEvent()
    {

    }
}