public class Running : Activity
{
    private double _distance;
    public Running(string date, double minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetPace()
    {
        return GetTime() / GetDistance();
    }

    public override double GetSpeed()
    {
        return GetDistance() * 60 / GetTime();
    }
}