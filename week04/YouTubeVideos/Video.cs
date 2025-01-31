using System;



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
    //public int NumOfComment()
    //{
        //return _comments.Count;
    //}
    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_lengthInSecond} seconds");
        Console.WriteLine($"Number of Comments: {_comments.Count}");

        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
        
    }
     
}    