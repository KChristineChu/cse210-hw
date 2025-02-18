using System;
using System.IO.Enumeration;
using System.Runtime;
using System.Security.Cryptography.X509Certificates;

namespace EternalQuest
{
    public class GoalManager
    {
        protected List<Goal> _goals;
        protected int _score;

        public GoalManager (List<Goal> goals, int score)
        {
            _goals = goals;                 
            _score = score;                         //set the score to begin at 0
        }

        public int GetScore()
        {
            return _score;
        }

       

        public void Start()
        {
            _score = 0;
            //Console.Write ($"You have {_score.DisplayPlayerInfo()} points." );

        }
        public void DisplayPlayerInfo()
        {
            //Displays the players current score.
           /*foreach (int point in _points)
            {
                _score += point;

            } */
            
            
            ListGoalNames();
            ListGoalDetails();


        }
        public void ListGoalNames()
        {
            int iterator = 1;
            foreach (var eachGoal in _goals)
            {
                Console.WriteLine($"{iterator}. {eachGoal.GetShortName()}");
                iterator++;
            }
            //Lists the names of each of the goals.
        }
        public void ListGoalDetails()
        {
            //Lists the details of each goal (including the checkbox of whether it is complete).

            Console.WriteLine ("The goals are: ");
            string goalLine = "";
            foreach (var eachGoal in _goals)
            {
                if (eachGoal.IsComplete())
                {
                    goalLine = "[x] ";
                }
                else
                {
                    goalLine = "[ ] ";
                }
               //goalLine += $"   {eachGoal.GetShortName()} ({eachGoal.GetDescription()})";
                goalLine += eachGoal.GetDetailsString();
                //Console.WriteLine ($"   {eachGoal.GetShortName()} ({eachGoal.GetDescription()})");'
                Console.WriteLine(goalLine);
            }
            //The goals are:
            //1. [ ] Give a talk (Speak in Sacrament meeting when asked)
            //2. [ ] Study the scriptures (Study for at least 10 minutes)
            //3. [ ] Attend the temple (Attend and perform any ordinance) -- Currently completed: 0/3
        }
        
        public void CreateGoal(string userInput2)
        {
          if (userInput2 == "1")
          {
            Console.WriteLine("What is the name of your goal? ");
            string shortName = Console.ReadLine();
            Console.WriteLine("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.WriteLine("What is the amount of points associated with this goal? ");  
            int points = Convert.ToInt32(Console.ReadLine());

            Goal goal1 = new SimpleGoal(shortName, description, points);
            
            _goals.Add(goal1);

          }
          else if (userInput2 == "2")
          {
            Console.WriteLine("What is the name of your goal? ");
            string shortName = Console.ReadLine();
            Console.WriteLine("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.WriteLine("What is the amount of points associated with this goal? ");  
            int points = Convert.ToInt32(Console.ReadLine()); 
            
          }

          else if (userInput2 == "3")
          {
            Console.WriteLine("What is the name of your goal? ");
            string shortName = Console.ReadLine();
            Console.WriteLine("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.WriteLine("What is the amount of points associated with this goal? ");  
            int points = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
            int target = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("What is the bonus for accomplishing it that many times? ");
            int bonus = Convert.ToInt32(Console.ReadLine()); 

            Goal goal3 = new ChecklistGoal(shortName, description, points, target, bonus);
            
            _goals.Add(goal3);
            //CheckListGoal(name : string, description : string, points : int, target : int, bonus : int) 
           
          }  
          
          else 
        {
            Console.WriteLine("Please select a type of goal from the menu ");
        } 
            
    }
                    
            

        public void RecordEvent()
        {
            ListGoalNames();
            Console.WriteLine ("Which goal did you accomplish? ");
            var userInput = Convert.ToInt32(Console.ReadLine());
            _goals[userInput-1].RecordEvent();              //index starts with 0, so minus 1
            var totalPoints = 0;
            foreach(var eachGoal in _goals)
            {
                if(eachGoal.IsComplete() == true)
                {
                    totalPoints += eachGoal.GetPoints();
                }
            }
            Console.WriteLine($"Congratulations! You have earned {totalPoints} points!");
            //score += totalPoints;
            //Console.WriteLine($"You now have {score} points.");

            // if(_isComplete == true)
            // {
            //    Console.WriteLine(_points);
            //    //Console.WriteLine(GetPoints());
            // }
        }
        public void SaveGoals(string filename)
        {
            Console.WriteLine ("What is the filename for the goal file? ");
            string savefileName = Console.ReadLine();
            //Goal.SaveGoals(saveFileName);        //?
        }
        public void LoadGoals(string filename)
        {
            Console.Write("Enter the filename to load from: ");
            //Console.Write("LoadGoal method");
            string loadFileName = Console.ReadLine();
            //Goal.LoadGoals(loadFileName);         //?

        }

        /*public void CreateGoal(SimpleGoal goal)
        {
            Console.WriteLine("What is the name of your goal? ");
            var shortName = Console.ReadLine();
            Console.WriteLine("What is a short description of it? ");
            var description = Console.ReadLine();
            Console.WriteLine("What is the amount of points associated with this goal? ");  //50
            var points = Convert.ToInt32(Console.ReadLine()); */

            //List<Goal> _goals = new List<Goal> (_shortName, _description, _points);//   //Then add the goal info to the list
           
            //Goal newGoal = new Goal(shortName, description, points);
            //_goals.Add(goal);//
            //GoalManager goalManager = new GoalManager(goal, score);
        
        


    }
}


    
