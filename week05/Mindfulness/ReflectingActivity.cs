using System;
using System.Diagnostics;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity (string name, string description, int duration) : base (name, description, duration)
    {
        _name = "Reflecting";
        _description = "reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life";

        Console.WriteLine("How long, in seconds, would you like for your session? ");
        _duration = Convert.ToInt32(Console.ReadLine());
    }

    
    public void Run()
    {

    }
    public string GetRandomPrompt()
    {

    }
    public string GetRandomQuestion()
    {

        Console.WriteLine("Now ponder each");
        //Console.WriteLine("You may begin in: {_countdown 5 sec}");
        

    }
    public void DisplayPrompt()
    {
        string prompt = PromptGenerator.GetRandomPrompt();
         Console.WriteLine($"Consider the following prompt: {prompt}");
         Console.WriteLine("When you have something in mind, press enter to continue.");


         //Console.Write("Write your entry: ");
         //string entryText = Console.ReadLine();
         //Entry entry = new(prompt, entryText); 
         //_entries.Add(entry);
        //Console.WriteLine("Entry added");
        
        


    }
    public void DisplayQuestions()
    {
        
    }
}



//Console.WriteLine ("Consider the following prompt: ");
//Console.WriteLine ("--- Think of a time when you did something really difficult. ---")
//Console.WriteLine ("When you have something in mind, press enter to continue.)