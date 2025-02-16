using System;

namespace EternalQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            
            

            while(true)
            {
                //Start();                              //Console.WriteLine("You have   points.");
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

                        if (userInput2 == "1")
                        {
                            CreateGoal();
                            SimpleGoal simpleGoal = new SimpleGoal ("","", 0, IsComplete = false);
                            

                        }
                        else if (userInput2 == "2")
                        {
                            CreateGoal();
                            EternalGoal eternalGoal = new EternalGoal ("", "", 0);
                        }
                        else if (userInput2 == "3")
                        {
                            CreateGoal();

                            RecordEvent();

                            ChecklistGoal checklistGoal = new ChecklistGoal ("", "", 0, 0, 0);

                        }
                        else 
                        {
                            Console.WriteLine("Please select a type of goal from the menu ");
                        }
                    }

                }

                else if (userInput1 == "2")
                {
                    Console.WriteLine ("The goals are: ");
                    //IsComplete();                          //on one line
                    //ListGoalNames();
                    //ListGoalDetails();
                }

                else if (userInput1 == "3")
                {
                    //SaveGoals();
                }

                else if (userInput1 == "4")
                {
                    //LoadGoals();
                

                }

                else if (userInput1 == "5")
                {

                }

                else if (userInput1 == "6")
                {
                    Console.WriteLine("Goodbye!");
                }

                else
                {
                    Console.WriteLine("Please select a choice from the menu ");
                }
            }
        }
    }
}