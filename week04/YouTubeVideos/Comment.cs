using System;

public class Comment
{
    protected string _commenter;
    protected string _text;

    public Comment(string commenter, string text)
    {
        _commenter = commenter;
        _text = text;
    }


    public string DisplayCommenterInfo()
    {
        return $"Name: {_commenter} \n Comment: {_text}";
        

    }

}