using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Transactions;

public class Video
{
   protected string _title;
   protected string _author;
   protected int _length;

   public List<Comment> _comments;

   public Video(string title, string author, int length)
   {
    _title = title;
    _author = author;
    _length = length;
    _comments = new List<Comment>();
   }
   public void AddComment(Comment comment)
   {
    _comments.Add(comment);

   }

    
   public int DisplayNumOfComments()
   {
        return _comments.Count;
    
    
   }
   

   public void DisplayInfo()
   {
    Console.WriteLine($"Title: {_title}");
    Console.WriteLine($"Author: {_author}");
    Console.WriteLine($"Length: {_length} seconds");
    Console.WriteLine($"Number of Comments: {_comments.Count}");
    Console.WriteLine($"Comments: ");

    foreach (Comment comment in _comments)
    {
        Console.WriteLine (comment.DisplayCommenterInfo());
    }
   }
 
}