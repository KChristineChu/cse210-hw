using System;
 
namespace mindfulness
{

   public class ListingActivity : Activity
    {
        private int _count;
        private List<string> _prompts;

        private List<string> Prompts = new List<string>
        {
            "--- Who are people that your appreciate? ---",
            "--- What are personal strengths of yours ---",
            "--- Who are people that you have helped this week? ---",
            "--- When have you felt the Holy Ghost this month? ---",
            "--- Who are some of your personal heroes? ---"
        };

        public ListingActivity(string name, string description, int duration) : base (name, description, duration)
        {
            _name = "Listing";
            _description = "reflect on the good things in your life by having you list as many things as you can in a certain area";

        }
        public void Run()
        {
            Console.Write("Get ready...\n");
            ShowSpinnerInSec();      //need more work for the method in Activity file
            
            GetRandomPrompt();

            GetListFromUser();


        }
        public void GetRandomPrompt()
        {
            Console.WriteLine("List as many responses you can to the following prompt: ");
            
            var random = new Random();
            Console.WriteLine(Prompts[random.Next(Prompts.Count)]);
            ShowCountDownInSec();

            Console.WriteLine("You may begin in: ");
            ShowCountDownInSec();

        }

        
        public void GetListFromUser()
        {
            

            DateTime currentTime = DateTime.Now;
            DateTime futureTime  = currentTime.AddSeconds(_duration);

            while(currentTime < futureTime) 
            {
                List<string> userList = new();

                Console.Write(">");
                string entry = Console.ReadLine();
                
                userList.Add(entry);
                _count = userList.Count;
                
                currentTime = DateTime.Now;

                
            }     
            
            Console.WriteLine($"You listed {_count} items!");    
        }

    } 

    //Console.Write("Write your entry: ");
            //string entryText = Console.ReadLine();
            //Entry entry = new(prompt, entryText); 
            //_entries.Add(entry);
          
    
}