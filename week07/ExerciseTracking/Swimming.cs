public class Swimming : Activity
{
    private int _laps;
    public Swimming(string date, double minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        double distance = _laps * 0.05;
        return distance;
    }

    public override double GetPace()
    {
        return GetTime() / GetDistance();
    }

    public override double GetSpeed()
    {
        double hours = GetTime() / 60;

        return GetDistance() / hours;
    }
}