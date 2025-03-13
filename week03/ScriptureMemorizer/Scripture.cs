public class Scripture
{
    private Reference _ref;
    private List<Word> _text;
    private bool _isCompletelyHidden = false;

    public Scripture(List<Word> text)
    {
        _text = text;
    }

    public Scripture(Reference reference, List<Word> text)
    {
        _ref = reference;
        _text = text;
    }

    public string HideRandomWords(int quantity)
    {
        for (int i = 0; i < quantity; i++)
        {
            Random generator = new Random();
            int index = generator.Next(0, _text.Count());
            while (_text[index].isHidden() && !_isCompletelyHidden)
            {
                index = generator.Next(0, _text.Count());
            }
            _text[index].Hide();
            _isCompletelyHidden = _text.All(x => x.isHidden());
        }
        Console.Clear();
        return GetDisplayText();
    }

    public bool isAllHidden()
    {
        return _isCompletelyHidden;
    }

    public string GetDisplayText()
    {
        string reference = _ref.GetDisplayText();
        List<string> words = new List<string>();

        foreach (var item in _text)
        {
            string word = item.GetDisplayText();
            words.Add(word);
        }
        string text = string.Join(" ", words);
        return $"{reference} {text}";
    }
}