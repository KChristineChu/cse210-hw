using System;
using System.Diagnostics;

public class BreathingActivity : Activity
{
    BreathingActivity breathingActivity(string name, string description, int duration) : base(name, description, duration)

    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear you mind and focus on your breathing.";
        Console.WriteLine();
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        _duration = Console.ReadLine();

        
    }

    public void Run()
    {
        Console.Write("Get ready...");
        Console.WriteLine();
        Console.Write($"Breath in ...{_ });
        Console.Write($"Breath out...{_ });
    }

    //Console.WriteLine("Welcome to the Breathing Activity.");
    //Console.WriteLine();
    //Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear you mind and focus on your breathing.");
    //Console.WriteLine();
    //Console.WriteLine("How long, in seconds, would you like for your session? ")
    //int _duration = Console.ReadLine();



    //Console.Write("Get ready...");
    //Console.Write();
    //Console.Write("Breath in ...{_ });
    //Console.Write("Breath out...{_ });

}