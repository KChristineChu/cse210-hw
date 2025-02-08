using System;
using System.Diagnostics;

public class BreathingActivity : Activity
{
    
    public BreathingActivity(string name="", string description="", int duration=0) : base(name, description, duration)

    {
        
        _name = "Breathing";
        _description = "relax by walking you through breathing in and out slowly. Clear you mind and focus on your breathing.";
        //SetName("Breathing");
        //SetDescription("relax by walking you through breathing in and out slowly. Clear you mind and focus on your breathing.");
        Console.WriteLine();

        //DisplayStartingMessage();
    
       // Console.WriteLine("How long, in seconds, would you like for your session? ");
       //_duration = Convert.ToInt32(Console.ReadLine());

        //Run();

    }    

    public void Run()
    {
        Console.Write("Get ready...\n");

        ShowSpinnerInSec();      //need more work for the method in Activity file
        
        Console.WriteLine("");
        
        DateTime currentTime = DateTime.Now;
        DateTime futureTime  = currentTime.AddSeconds(_duration);
        while(currentTime < futureTime) 
        {
            Console.Write($"Breath in ...");  //another variable  count down
            ShowCountDownInSec();
            Console.WriteLine("");
            Console.Write($"Breath out...");   //another variable  count down
            ShowCountDownInSec();
            Console.WriteLine("");
            currentTime = DateTime.Now;
            
        }
    }

    public void InputDurationTime()
    {
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        _duration = Convert.ToInt32(Console.ReadLine());

    }
    //public void CountDown
    
    
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