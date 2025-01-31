using System;

public class Comment
{
    private string _username;
    private string _text;

    public void DisplayComment()
    {
        Console.WriteLine($"Name: {_username}");
        //Console.WriteLine($"Comment: {_text}");

        foreach (Video video in videos)
        {
            
            Console.WriteLine(video);

            foreach (Comment comment in comments);
            {
                Console.WriteLine(comment);
            }
        }


    }
}
