using System;

class Program
{
    static void Main(string[] args)
    {
        Video v1 = new Video("The New World", "Marcus Rudolf", 242);
        v1._comments.Add(new Comment("Barbara", "This is very entertaining"));
        v1._comments.Add(new Comment("MusaKeys", "I like it :-)"));
        v1._comments.Add(new Comment("BlessTheBlesser", "Hahahaha, this is funny"));

        Video v2 = new Video("How to dance", "KwaraStreet", 503);
        v2._comments.Add(new Comment("Maggie Strauss", "I cannot dance to save my life"));
        v2._comments.Add(new Comment("Gugue Lethu", "I aced this dance like a boss ;->"));
        v2._comments.Add(new Comment("Zamani Mafu", "This is very helpful, thank you @KwaraStreet"));

        Video v3 = new Video("China vs USA", "GeoPolitix", 1054);
        v3._comments.Add(new Comment("Rico Redd", "I knew this tarrif thing would backfire"));
        v3._comments.Add(new Comment("Gregory Sykes", "I hope the Trump administration understands that once the world learns to live without us, there's no going back"));
        v3._comments.Add(new Comment("Brian O'Brien", "Europe has to do better in being an independent block"));

        Video v4 = new Video("The depths of the ocean", "Animal Kingdom", 720);
        v4._comments.Add(new Comment("PapaSmurf", "The whales are such gentle giants"));
        v4._comments.Add(new Comment("Hilda May", "I like how intelligent dolphins are"));
        v4._comments.Add(new Comment("Samantha Smith", "I could watch this all day"));

        List<Video> videos = [v1, v2, v3, v4];

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video._title} \nAuthor: {video._author} \nDuration: {video._duration}s \nComments: {video.numberOfComments()}");
            foreach (var comment in video._comments)
            {
                Console.WriteLine($"{comment._username}: {comment._commentText}");
            }
            Console.WriteLine("\n");
        }
    }
}