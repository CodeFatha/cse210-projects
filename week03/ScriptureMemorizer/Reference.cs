public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse, int endVerse = 0)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        string verses = _endVerse > 0 ? $"{_verse}-{_endVerse}" : $"{_verse}";
        return $"{_book} {_chapter}:{verses}";
    }
}