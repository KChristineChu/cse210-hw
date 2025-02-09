using System;
using System.Diagnostics;

namespace mindfulness
{
    public class ReflectingActivity : Activity
    {
        private List<string> _prompts;
        private List<string> _questions;


        private List<string> Prompts = new List<string>
        {
            "--- Think of a time when you stood up for someone else. ---",
            "--- Think of a time when you did something really difficult. ---",
            "--- Think of a time when you helped someone in need. ---",
            "--- Think of a time when you did something truly selfless. ---"
        };

        private List<string> Questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "How you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
            
        };

        public ReflectingActivity (string name, string description, int duration) : base (name, description, duration)
        {
            _name = "Reflecting";
            _description = "reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life";

        }

        
        public void Run()
        {
            Console.Write("Get ready...\n");
            ShowSpinnerInSec();      
            
            DisplayPrompt();

            DisplayQuestions();

            
                
            
        }
        public void GetRandomPrompt()
        {
            
            var random = new Random();
            Console.WriteLine(Prompts[random.Next(Prompts.Count)]);
        }
        public void GetRandomQuestion()
        {
            var random = new Random();
            Console.WriteLine(Questions[random.Next(Questions.Count)]);

        }
        public void DisplayPrompt()
        {
            
            Console.WriteLine("Consider the following prompt: ");
            GetRandomPrompt();
         

        }
        public void DisplayQuestions()
        {
            Console.WriteLine("When you have something in mind, press enter to continue");
            string _userReply = Console.ReadLine();

            if (_userReply != "")
            {

                Console.WriteLine("Now ponder each of the following questions as they related to this experience. ");
            
                Console.WriteLine("You may begin in: ");
                ShowCountDownInSec();
            }

            DateTime currentTime = DateTime.Now;
            DateTime futureTime  = currentTime.AddSeconds(_duration);
            while(currentTime < futureTime) 
            {
                GetRandomQuestion();
                ShowCountDownInSec();

                currentTime = DateTime.Now;
                
            }


            
        }
    }

}


