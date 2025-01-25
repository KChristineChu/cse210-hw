using System.Security.Cryptography.X509Certificates;

public class Word
{
    private string _text;

    private bool _isHidden;

    public Word(string text)
    {
       _text = text;
       _isHidden = false;   // Set to show words at beginning
    }

    public void Hide()       //hide the word
    {
        _isHidden = true;

    }
    public void Show()
    {
        _isHidden = false;
    }
    public bool IsHidden()
    {
        return _isHidden;  //return the current hidden state of the word
    }
    public string GetDisplayText()
    {
        //return the word if visible or return underscores ___ if hidden
        if (_isHidden)
        {
            return new string('_', _text.Length);  //so smart
        }
        
        return _text;  //return the word if visible
        
        

    }
    

}