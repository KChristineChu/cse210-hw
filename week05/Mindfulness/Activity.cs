using System;

namespace mindfulness
{

    public class Activity
    {
        protected string _name = "";
        protected string _description = "";
        protected int _duration = 0;

        public Activity (string name, string description, int duration)
        {                
            _name = name;
            _description = description;
            _duration = duration;       
        }


        public void DisplayStartingMessage()
        {    
            Console.WriteLine($"Welcome to the {_name} Activity" );
            Console.WriteLine("");
            Console.WriteLine($"This activity will help you {_description}");
        }  

        public void DisplayEndingMessage()
        {
            Console.Write("Well done!!");
            ShowSpinnerInSec();

            Console.WriteLine("");
            Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity");
            ShowSpinnerInSec();
        }

        public void InputDurationTime()
    {
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        _duration = Convert.ToInt32(Console.ReadLine());

    }
        public void ShowSpinnerInSec()
        {
            
            List<string> spinnerStrings = new List<string>();
            spinnerStrings.Add ("|");
            spinnerStrings.Add ("/");
            spinnerStrings.Add ("_");
            spinnerStrings.Add ("\\");
            //spinnerStrings.Add ("|");
            //spinnerStrings.Add ("/");
            //spinnerStrings.Add ("_");
            //spinnerStrings.Add ("\\");

            foreach  (string s in spinnerStrings)
            {
               Console.Write(s);
               Thread.Sleep (1000);
               Console.Write("\b \b"); 
            }

        }
        public void ShowCountDownInSec()
        {
            for (int i = 4; i > 0; i--)
            {
                Console.Write(i);                     
                Thread.Sleep(1000);
                Console.Write("\b \b");       //backspace, 1 space between for single digit, 2 spaces for 2 digits. place new number on top of the previous one
            }

                //Console.Write(".");            // add a dot at a second  ....         
                //Thread.Sleep(1000); 
            
        }

        
    }
}    

    

