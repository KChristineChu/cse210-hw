using System;
using System.Diagnostics;

namespace mindfulness;

    public class BreathingActivity : Activity
    {
        
        public BreathingActivity(string name="", string description="", int duration=0) : base(name, description, duration)

        {
            
            _name = "Breathing";
            _description = "relax by walking you through breathing in and out slowly. Clear you mind and focus on your breathing.";
            
            Console.WriteLine();

            //DisplayStartingMessage();
        
        // Console.WriteLine("How long, in seconds, would you like for your session? ");
        //_duration = Convert.ToInt32(Console.ReadLine());

           

        }    

        public void Run()
        {
            Console.Write("Get ready...\n");

            ShowSpinnerInSec();      
            
            Console.WriteLine("");
            
            DateTime currentTime = DateTime.Now;
            DateTime futureTime  = currentTime.AddSeconds(_duration);
            while(currentTime < futureTime) 
            {
                Console.Write($"Breath in ...");  
                ShowCountDownInSec();
                Console.WriteLine("");
                Console.Write($"Breath out...");   
                ShowCountDownInSec();
                Console.WriteLine("");
                currentTime = DateTime.Now;
                
            }
        }
    }

   
    

