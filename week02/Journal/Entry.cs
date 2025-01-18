
using System;

public class Entry
{
    public string Date { get; }
    public string PromptText { get; }
    public string EntryText { get; }
 
    public Entry(string promptText, string entryText)
    {
        Date = DateTime.Now.ToString("MM/dd/yyyy");
        PromptText = promptText;
        EntryText = entryText;
    }
 
    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {PromptText}");
        Console.WriteLine($"Entry: {EntryText}");
        Console.WriteLine(new string('-', 40));
    }
}