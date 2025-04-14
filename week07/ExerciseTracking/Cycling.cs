public class Cycling : Activity
{
    private double _speed;
    public Cycling(string date, double minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _speed * GetTime() / 60;
    }

    public override double GetPace()
    {
        return GetTime() / GetDistance();
    }

    public override double GetSpeed()
    {
        return _speed;
    }
}