using System;
using System.IO;
using System.Collections.Generic;

public class Journal
{
     private readonly List<Entry> _entries = new List<Entry>();

     public void AddEntry()
     {
         string prompt = PromptGenerator.GetRandomPrompt();
         Console.WriteLine($"Prompt: {prompt}");
         Console.Write("Write your entry: ");
         string entryText = Console.ReadLine();
         Entry entry = new(prompt, entryText); 
         _entries.Add(entry);
        Console.WriteLine("Entry added");
     }



    public void DisplayAll()
     {
         foreach (var entry in _entries)
         {
             entry.Display();
         }
     }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine($"{entry.Date}|{entry.PromptText}|{entry.EntryText}");
            }
        }
        Console.WriteLine($"Journal saved to {fileName}");
    }
 
    public void LoadFromFile(string fileName)
    {
        if (!File.Exists(fileName))
        {
            Console.WriteLine("File not found.");
            return;
        }
 
        _entries.Clear();
        foreach (var line in File.ReadAllLines(fileName))
        {
            var parts = line.Split('|');
            if (parts.Length == 3)
            {
                _entries.Add(new Entry(parts[1], parts[2]));
            }
        }
        Console.WriteLine($"Journal loaded from {fileName}");
    }
}
 