using System;

namespace EternalQuest
{
    class Program 
    {
        static void Main(string[] args)
        {
            
            var goal = new List<Goal>();
            int score = 0;
            GoalManager goalManager = new GoalManager(goal, score);
            while(true)
            {
                //Start();
                Console.WriteLine("");                              
                Console.WriteLine($"You have {score}  points.");
                Console.WriteLine("");
                
                Console.WriteLine("Menu Options: ");

                Console.WriteLine("1. Create New Goal");
                Console.WriteLine("2. List Goals");
                Console.WriteLine("3. Save Goals");
                Console.WriteLine("4. Load Goals");
                Console.WriteLine("5. Record Events");
                Console.WriteLine("6. Quit");

                Console.Write("Select a choice from the menu: ");
                string userInput1 = Console.ReadLine();

                if (userInput1 == "1")
                {
                    while(true)
                    {
                        Console.WriteLine("The types of Goals are: ");

                        Console.WriteLine("1. Simple Goal");
                        Console.WriteLine("2. Eternal Goal");
                        Console.WriteLine("3. Checklist Goal");

                        Console.Write("What type of goal would you like to create? ");
                        string userInput2 = Console.ReadLine();
                        
                        
                        goalManager.CreateGoal(userInput2);
                        //goalManager.ListGoalDetails();
                        break;
                        
                    }
                }       
            

                else if (userInput1 == "2")
                {
                    
                    goalManager.ListGoalDetails();
                }

                else if (userInput1 == "3")
                {
                    goalManager.SaveGoals();
                }

                else if (userInput1 == "4")
                {
                    goalManager.LoadGoals();
                

                }

                else if (userInput1 == "5")
                {
                    goalManager.RecordEvent();
                }

                else if (userInput1 == "6")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }

                else
                {
                    Console.WriteLine("Please select a choice from the menu ");
                }
            }
        }
    }
}