using System;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry()
    {
        string prompt = PromptGenerator.GetRandomPrompt();
        Console.WriteLine(prompt);
        Console.Write("Write the text of your entry.");
        string entryText = Console.ReadLine();
        Entry entry = new(prompt, entryText);
        _entries.Add(entry);

    } 

    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string file)
    {

    } 

    public void LoadFromFile(string file)
    {
        
    }  
}