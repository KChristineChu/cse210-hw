using System;
using System.IO.Enumeration;

namespace EternalQuest
{
    public class GoalManager
    {
        private List<Goal> _goal;
        private int _score;

        public List<Goal> GetGoal()
        {
            return _goal;
        }
        public int GetScore()
        {
            return _score;
        }

        public GoalManager (List<Goal> goal, int score)
        {
            _goal = goal;
            _score = score;
        }

        public void Start()
        {
            _score = 0;
            Console.Write ($"You have {_score} points." );

        }
        public void DisplayPlayerInfo()
        {
            Console.WriteLine ("The goals are: ");
            //Console.Write("[]");
            ListGoalNames();
            ListGoalDetails();


        }
        public void ListGoalNames()
        {
            // list _shortName
        }
        public void ListGoalDetails()
        {
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
            _points = Console.ReadLine();
            Console.WriteLine ("How many times does this goal need to be accomplished for a bonus? "); //3
            _number = Console.ReadLine();
            Console.WriteLine ("What is the bonus for accomplishing it that many times? ");       //500
            _bonusPoints = Console.ReadLine();

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


    
