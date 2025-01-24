public class Reference
{
    private string _book;

    private int _chapter;
    private int _verse;

    private int _endVerse;

    public Reference(string book, int chapter, int verse)     //1st constructor
    {
        //decide what to set _endVerse equal to int

    }
    public Reference(string book, int chapter, int startVerse, int endVerse)  //2nd constructor
    {
        
    }
    public string GetDisplayText()
    {
        //2 ways to return the string:
        // John 3:16
        // Proverbs 3:5-6 (need a dash and _endVerse)
        return "";

    }
}   