public class Entry
{
    public string _date;
    public string _prompt;
    public string _response;

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date} \nPrompt: {_prompt} \n{_response}\n");
    }
}
