public class Scripture
{
    private Reference _reference;   //scripture reference e.g. Proverbs..

    private List<Word> _words;  //list of words in the scripture

    public Scripture(Reference reference, string text)  //Reference : user-defined class, custom type, capital
    {
        //split up the word in text and store each as a word object in the list _words
        //e.g. string name = "";
        //string[] words = name.Split("");

        //split and then loop through each word
        //create word object and put it into _words
        //string name = "";
        _reference = reference;

        string[] words = text.Split();
        //foreach (string word in words)
        //Console.Write(word);
    

    }
    public void HideRandomWords(int numberToHide)
    {
        //hardest -set the state of a randomly selected group of words to be hidden
        //need to find a set of visible words
        //need to randomly select 'numberToHide' of those words e.g. loops...
        //use the Hide function
    }
    public string GetDisplayText()
    {
        //display Reference, all the Words
        //e.g. string text = "abc" + "def";
        

    }
    public bool IsCompletelyHidden()
    {
        return false;

    }
}