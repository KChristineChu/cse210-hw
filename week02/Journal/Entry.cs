using System;
public class Entry(string promptText, string entryText)
{
    public string _date = DateTime.Now.Date.ToString("MM/dd/yyyy");
    public string _promptText = promptText;
    public string _entryText = entryText;

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");        
    }           
}