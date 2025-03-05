public class Job
{
    public string _jobTitle;
    public string _company;
    public string _startYear;
    public string _endYear;

    public void DisplayJobDetails()
    {
        string endYear = _endYear == "" || _endYear == null ? "Present" : _endYear;
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear} - {endYear}");
    }

}