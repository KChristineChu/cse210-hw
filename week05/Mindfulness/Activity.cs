using System;



    public class Activity
    {
        protected string _name;
        protected string _description;
        protected int _duration;

        public Activity (string name, string description, int duration)
        {

        }


        public void DisplayStartingMessage()
        {
            
            Console.WriteLine($"Welcome to the {_name} Activity" );
            Console.WriteLine();
            Console.WriteLine($"This activity will help you {_description}");
        }  

        public void DisplayEndingMessage()
        {
            Console.Write("Well done!");
            Console.WriteLine();
            Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity");
        }
        public void ShowSpinnerInSec()
        {
            Console.WriteLine("Get ready");

            List<string> spinner = new List<string>();
            spinner.Add ("|");
            spinner.Add ("/");
            spinner.Add ("_");
            spinner.Add ("\\");
            spinner.Add ("|");
            spinner.Add ("/");
            spinner.Add ("_");
            spinner.Add ("\\");

            //foreach  (string s in spinner)
            {
               // Console.Write(5);
               // Thread.Sleep (1000);
                
            }

        }
        public void ShowCountDownInSec()
        {
            
        }
    }
    
    

    //for(int i = _duration; i < 0; i--)  
    //{
        //Console.Write(i);
        //Thread.Sleep (1000);
        //Console.Write("\b \b");