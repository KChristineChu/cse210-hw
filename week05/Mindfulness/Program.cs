using System;
using System.Diagnostics;

namespace mindfulness
{
    class Program
    {
        static void Main(string[] args)
        {
            
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
                BreathingActivity breathingActivity1 = new BreathingActivity("", "", 0);
                breathingActivity1.DisplayStartingMessage();
                breathingActivity1.InputDurationTime();
                breathingActivity1.Run();
                breathingActivity1.DisplayEndingMessage();
                
                }
                else if (userInput == "2")
                {
                //activity.ReflectingActivity();
                ReflectingActivity reflectingActivity1 = new ReflectingActivity("", "", 0);
                reflectingActivity1.DisplayStartingMessage();
                reflectingActivity1.InputDurationTime();
                reflectingActivity1.Run(); 
                reflectingActivity1.GetRandomPrompt();
                reflectingActivity1.DisplayEndingMessage();
                }
                else if (userInput == "3")
                {
                    //activity.ListingActivity();
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
}