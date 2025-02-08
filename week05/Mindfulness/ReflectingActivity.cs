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




        //public BreathingActivity(string name="", string description="", int duration=0) : base(name, description, duration)

        public ReflectingActivity (string name, string description, int duration) : base (name, description, duration)
        {
            _name = "Reflecting";
            _description = "reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life";

            //Console.WriteLine("How long, in seconds, would you like for your session? ");
            //_duration = Convert.ToInt32(Console.ReadLine());
        }

        
        public void Run()
        {
            Console.Write("Get ready...\n");

            ShowSpinnerInSec();      //need more work for the method in Activity file
            Console.WriteLine("Now ponder each");
            Console.WriteLine("");
            Console.Write("You may begin in: ");
            DateTime currentTime = DateTime.Now;
            DateTime futureTime  = currentTime.AddSeconds(_duration);
            while(currentTime < futureTime) 
            {
                GetRandomQuestion();
                ShowCountDownInSec();

                currentTime = DateTime.Now;
                
            }
        }
        public void GetRandomPrompt()
        {
            Console.WriteLine("Consider the following prompt: ");
            var random = new Random();
            Console.WriteLine(Prompts[random.Next(Prompts.Count)]);
        }
        public void GetRandomQuestion()
        {

            //Console.WriteLine("Now ponder each");
            
            //Console.Write("You may begin in: ");
            //ShowCountDownInSec();
            var random = new Random();
            Console.WriteLine(Questions[random.Next(Questions.Count)]);

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

}


//Console.WriteLine ("Consider the following prompt: ");
//Console.WriteLine ("--- Think of a time when you did something really difficult. ---")
//Console.WriteLine ("When you have something in mind, press enter to continue.)

