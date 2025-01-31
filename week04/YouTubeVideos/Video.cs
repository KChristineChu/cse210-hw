using System;
using System.Transactions;

public class Video
{
    public string _title;
    public string _author;

    public int _lengthInSecond;

    public List<Comment> _comments = new List<Comment>();

    public void DisplayInfo()
    {
        Console.WriteLine(_title);
        Console.WriteLine(_author);
        Console.WriteLine(_lengthInSecond);
    }
     
}    