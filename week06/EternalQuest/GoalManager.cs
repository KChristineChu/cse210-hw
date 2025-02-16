using System;
using System.IO.Enumeration;

namespace EternalQuest
{
    public class GoalManager 
    {
        private List<Goal> _goals;
        private int _score;

        public List<Goal> GetGoals()
        {
            return _goals;
        }
        public int GetScore()
        {
            return _score;
        }

        public GoalManager (List<Goal> goal, int score)
        {
            _goals = goal;                 
            _score = score;                         //set the score to begin at 0
        }

        public void Start()
        {
            _score = 0;
            Console.Write ($"You have {_score.DisplayPlayerInfo()} points." );

        }
        public void DisplayPlayerInfo()
        {
            //Displays the players current score.
            foreach (int point in _points)
            {
                _score += point;

            }
            
            
            ListGoalNames();
            ListGoalDetails();


        }
        public void ListGoalNames()
        {
            foreach (var shortName in _shortName)
            {
                Console.WriteLine(shortName);
            }
            //Lists the names of each of the goals.
            // list _shortName
        }
        public void ListGoalDetails()
        {
            //Lists the details of each goal (including the checkbox of whether it is complete).

            Console.WriteLine ("The goals are: ");
            Console.WriteLine ($"   {_shortName} ({_description})");
            //The goals are:
            //1. [ ] Give a talk (Speak in Sacrament meeting when asked)
            //2. [ ] Study the scriptures (Study for at least 10 minutes)
            //3. [ ] Attend the temple (Attend and perform any ordinance) -- Currently completed: 0/3
        }
        public void CreateGoal()
        {
            Console.WriteLine("What is the name of your goal? ");
            _shortName = Console.ReadLine();
            Console.WriteLine("What is a short description of it? ");
            _description = Console.ReadLine();
            Console.WriteLine("What is the amount of points associated with this goal? ");  //50
            _points = Convert.ToInt32(Console.ReadLine());

            List<Goal> _goals = new List<Goal> (_shortName, _description, _points);//   //Then add the goal info to the list

        }
        public void RecordEvent()
        {

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
            string loadFileName = Console.ReadLine();
            //Goal.LoadGoals(loadFileName);         //?

        }
    }
}


    
