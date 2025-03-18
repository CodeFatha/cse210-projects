public class Video
{
    public List<Comment> _comments = new();
    public string _title;
    public string _author;
    public int _duration;

    public Video(string title, string author, int duration)
    {
        _title = title;
        _author = author;
        _duration = duration;
    }

    public int numberOfComments()
    {
        return _comments.Count;
    }
}