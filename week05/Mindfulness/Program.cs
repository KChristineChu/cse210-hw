using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Activity activity = new Activity();

        while (true)
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");

            Console.Write("Select a choice from the menu: ");
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
              activity.BreathingActivity();  
            }
            else if (userInput == "2")
            {
               activity.ReflectingActivity(); 
            }
            else if (userInput == "3")
            {
                activity.ListingActivity();
            }
            else if (userInput == "4")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Please choose 1, 2, 3 or 4");
            }
        }
        
    }
}