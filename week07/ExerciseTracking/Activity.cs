public abstract class Activity
{
    private string _date;
    private double _minutes;
    public Activity(string date, double minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public string GetSummary(string type)
    {
        return $"{_date} {type} ({_minutes} minutes) - Distance: {GetDistance()} km, Speed: {GetSpeed()} km/h, Pace: {GetPace()} min per km";
    }

    public double GetTime()
    {
        return _minutes;
    }

}