using System;



    public class Activity
    {
        protected string _name;
        protected string _description;
        protected int _duration;

        public Activity (string name, string description, int duration)
        {
            _name = name;
            _description = description;
            _duration = duration;

        }


        public void DisplayStartingMessage()
        {
            
            Console.WriteLine($"Welcome to the {_name} Activity" );
            Console.WriteLine();
            Console.WriteLine($"This activity will help you {_description}");
        }  

        public void DisplayEndingMessage()
        {
            Console.Write("Well done!!");
            ShowSpinnerInSec();

            Console.WriteLine();
            Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity");
            ShowSpinnerInSec();
        }
        public void ShowSpinnerInSec()
        {
            Console.WriteLine("Get ready");

            List<string> spinnerStrings = new List<string>();
            spinnerStrings.Add ("|");
            spinnerStrings.Add ("/");
            spinnerStrings.Add ("_");
            spinnerStrings.Add ("\\");
            spinnerStrings.Add ("|");
            spinnerStrings.Add ("/");
            spinnerStrings.Add ("_");
            spinnerStrings.Add ("\\");

            foreach  (string s in spinnerStrings)
            {
               Console.Write(s);
               Thread.Sleep (1000);
               Console.Write("\b \b"); 
            }

        }
        public void ShowCountDownInSec()
        {
            for (int i = 5; i > 0; i--)
            {
                Console.Write(i);                     
                Thread.Sleep(1000);
                Console.Write("\b \b");       //backspace, 1 space between for single digit, 2 spaces for 2 digits. place new number on top of the previous one
            }

                //Console.Write(".");            // add a dot at a second  ....         
                //Thread.Sleep(1000);

            //Console.WriteLine(5);
            //Thread.Sleep(1000);
            //Console.WriteLine(4);
            //Thread.Sleep(1000);
            //Console.WriteLine(3);
            //Thread.Sleep(1000);
            //Console.WriteLine(2);
            //Thread.Sleep(1000);
            //Console.WriteLine(1);
            //Thread.Sleep(1000);
            
        }
    }
    
    

    //for(int i = _duration; i < 0; i--)  
    //{
        //Console.Write(i);
        //Thread.Sleep (1000);
        //Console.Write("\b \b");