public class Word
{
    private string _text;
    private bool _ishidden = false;

    public Word()
    {
        _text = "";
    }

    public Word(string word)
    {
        _text = word;
    }

    public void Hide()
    {
        for (int i = 0; i < _text.Count(); i++)
        {
            if (!_text[i].Equals(',') && !_text[i].Equals('.'))
            {
                _text = _text.Replace(_text[i], '_');
            }
        }

        _ishidden = true;
    }

    public void Show()
    {
        Console.Write(_text);
    }

    public bool isHidden()
    {
        return _ishidden;
    }

    public string GetDisplayText()
    {
        return _text;
    }
}