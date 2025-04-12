public class ChecklistGoal : Goal
{
    private int _completed;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override string GetFormattedString()
    {
        return $"{GetName()} ({GetDescription()}) --- Completed {_completed}/{_target}";
    }

    public override bool IsComplete()
    {
        return (_completed / _target) >= 1;
    }

    public override void RecordEvent()
    {
        _completed++;
    }

    public int GetBonus()
    {
        return _bonus;
    }
    public void ResetCompleted()
    {
        _completed = 0;
    }
}