using System;
using System.Diagnostics;

public class BreathingActivity : Activity
{
    
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)

    {
        
        _name = "Breathing";
        _description = "relax by walking you through breathing in and out slowly. Clear you mind and focus on your breathing.";
        Console.WriteLine();

        DisplayStartingMessage();
    
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        _duration = Convert.ToInt32(Console.ReadLine());

    }    

    public void Run()
    {
        Console.Write("Get ready...");

        ShowSpinnerInSec();      //need more work for the method in Activity file
        

        Console.WriteLine();
        Console.Write($"Breath in ...{_duration}");  //another variable  count down
        Console.Write($"Breath out...{_duration}");   //another variable  count down
    }

    DisplayEndingMessage();
    
    
    
    //Console.WriteLine("Welcome to the Breathing Activity.");
    //Console.WriteLine();
    //Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear you mind and focus on your breathing.");
    //Console.WriteLine();
    //Console.WriteLine("How long, in seconds, would you like for your session? ")
    // _duration = Console.ReadLine();



    //Console.Write("Get ready...");
    //Console.Write();
    //Console.Write("Breath in ...{_ });   count backward
    //Console.Write("Breath out...{_ });   count backward

}