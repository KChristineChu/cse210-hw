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
                   
                        Console.WriteLine("The types of Goals are: ");

                        Console.WriteLine("1. Simple Goal");
                        Console.WriteLine("2. Eternal Goal");
                        Console.WriteLine("3. Checklist Goal");

                        Console.Write("What type of goal would you like to create? ");
                        string userInput2 = Console.ReadLine();



                        //if (userInput2 == "1")
                        //{
                            /*Console.WriteLine("What is the name of your goal? ");
                            var shortSimpleName = Console.ReadLine();
                            Console.WriteLine("What is a short description of it? ");
                            var simpleDescription = Console.ReadLine();
                            Console.WriteLine("What is the amount of points associated with this goal? ");  
                            var simplePoints = Convert.ToInt32(Console.ReadLine());   
           
                            SimpleGoal newSimpleGoal = new SimpleGoal(shortSimpleName, simpleDescription, simplePoints);*/
                            //goalManager.CreateGoal(newSimpleGoal);
                            goalManager.CreateGoal(userInput2);
                        }
                        //else if (userInput2 == "2")
                        //{
                            //goalManager.CreateGoal();
                            //EternalGoal eternalGoal = new EternalGoal ("", "", 0);
                        //}
                        //else if (userInput2 == "3")
                        //{
                            //CreateGoal();

                            //RecordEvent();

                            //ChecklistGoal checklistGoal = new ChecklistGoal ("", "", 0, 0, 0);
                        /*
                        }
                        else 
                        {
                            Console.WriteLine("Please select a type of goal from the menu ");
                        }*/
                    

               // }

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