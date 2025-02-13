using System;

public class Comment
{
    protected string _commenter;
    protected string _text;

    public string DisplayCommenterInfo()
    {
        return $"Name: {_commenter} \n Comment: {_text}";
        

    }

}