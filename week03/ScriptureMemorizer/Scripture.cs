using System;
using System.Collections.Generic;
public class Scripture
{
    private Reference _reference;   //scripture reference e.g. John 3:16,17

    private List<Word> _words;  //list of words in the scripture

    public Scripture(Reference reference, string text)  //Reference : user-defined class, custom type, capital
    {
        //split up the word in text and store each as a word object in the list _words
        //e.g. string name = "";
        //string[] words = name.Split("");

        //split and then loop through each word
        //create word object and put it into _words
        
        _reference = reference;

        _words = new List<Word>();
        string[] words = text.Split(' ');
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
      
    }

    public void HideRandomWords(int numberToHide)
    {
        //set the state of a randomly selected group of words to be hidden
        //need to find a set of visible words
        //need to randomly select 'numberToHide' of those words e.g. loops...
        //use the Hide function

        List<Word> visibleWords = _words.Where(word => !word.IsHidden()).ToList();
        
        Random random = new Random();
        
        int wordsToHide = Math.Min(numberToHide, visibleWords.Count);
        
        for (int i = 0; i < wordsToHide; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }

    }
    public string GetDisplayText()
    {
        //display Reference, all the Words
        //e.g. string text = "abc" + "def";

        string scriptureText = "";

        foreach (Word word in _words)
        {
            scriptureText += word.GetDisplayText() + " ";
        }

        return _reference.GetDisplayText() + " " + scriptureText;
        
    }
    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());

    }
}