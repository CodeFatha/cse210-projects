public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override string GetFormattedString()
    {
        return $"{GetName()} ({GetDescription()})";
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }
    public void SetIsComplete(bool isComplete)
    {
        _isComplete = isComplete;
    }
}