using System;



    public class Activity
    {
        protected string _name;
        protected string _description;
        protected int _duration;

        public Activity()
        {

        }


        public void DisplayStartingMessage()
        {
            
            Console.WriteLine($"Welcome to the {_name} Activity" );
            Console.WriteLine();
        }  

        public void DisplayEndingMessage()
        {
            Console.Write("Well done!");
            Console.WriteLine();
            Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity");
        }
        public void ShowSpinnerInSec()
        {

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