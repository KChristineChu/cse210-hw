using System;
using System.Security.AccessControl;

public class Comment
{
    public string _commenter;
    public string _text;

    
    //public Comment(string commenter, string text)
    //{
       // _commenter = commenter;
        //_text = text;
    //}
    public void DisplayComment(string commenter, string text)
    {   {
            _commenter = commenter;
            _text = text;
    
        Console.WriteLine($"Name: {_commenter}");
        Console.WriteLine($"Comment: {_text}");

    }    

           // foreach (Comment comment in comments);
          //  {
               // Console.WriteLine(comment);
            //}
        }


    }
}
