using System;
using System.Collections.Generic;

class Comment
{
    public string Name { get; set; }
    public string Text { get; set; }

    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }
}

class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; } 

    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {Length} seconds");
        Console.WriteLine($"Number of Comments: {GetCommentCount()}");
        Console.WriteLine("Comments:");
        foreach (var comment in _comments)
        {
            Console.WriteLine($"- {comment.Name}: {comment.Text}");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video v1 = new Video("Exploring the Alps", "TravelVlog", 345);
        v1.AddComment(new Comment("Alice", "Loved this view!"));
        v1.AddComment(new Comment("Bob", "This is so relaxing"));
        v1.AddComment(new Comment("Clara", "I'm adding this to my bucket list!"));
        videos.Add(v1);

        Video v2 = new Video("Best Coding Tips", "CodeMaster", 420);
        v2.AddComment(new Comment("Derek", "Tip #3 blew my mind"));
        v2.AddComment(new Comment("Eve", "Thanks! Very useful."));
        v2.AddComment(new Comment("Frank", "Subscribed!"));
        videos.Add(v2);

        Video v3 = new Video("10 Minute Yoga", "ZenLife", 600);
        v3.AddComment(new Comment("Grace", "Perfect for my mornings"));
        v3.AddComment(new Comment("Helen", "Nice voice and flow"));
        v3.AddComment(new Comment("Ian", "Can you make one for back pain?"));
        videos.Add(v3);

        Video v4 = new Video("Spectra App Demo", "SpectraAI", 215);
        v4.AddComment(new Comment("Julia", "This tool looks amazing!"));
        v4.AddComment(new Comment("Kevin", "Can I use it for anxiety?"));
        v4.AddComment(new Comment("Liam", "Great UI design."));
        videos.Add(v4);

        foreach (var video in videos)
        {
            video.DisplayInfo();
        }
    }
}
