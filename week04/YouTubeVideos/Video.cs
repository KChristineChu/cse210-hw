using System;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

public class Video
{
    public string _title;
    public string _author;

    public int _lengthInSecond;

    public List<Comment> _comments = new List<Comment>();
    public void AddComment (Comment comment)
    {
        _comments.Add(comment);
    }
    public int NumOfComment()
    {
        return _comments.Count;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_lengthInSecond} seconds");
    }
     
}    