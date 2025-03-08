public class Prompts
{
    public List<string> _questions = new List<string>();

    public string PickRandomQuestion()
    {
        _questions.Add("What was the highlight of your day? ");
        _questions.Add("What was the lowest point of your day? ");
        _questions.Add("What kind thing did you do for someone? ");
        _questions.Add("Who made your day memorable? ");
        _questions.Add("How would you do things different if you were to live this day again? ");
        _questions.Add("Describe an emotion you experienced today? ");
        _questions.Add("What do you look forward to the most tomorrow? ");

        Random random = new Random();
        int index = random.Next(0, _questions.Count - 1);

        return _questions[index];
    }
}