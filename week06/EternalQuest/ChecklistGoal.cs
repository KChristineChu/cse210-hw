using System;

namespace EternalQuest
{
    public class ChecklistGoal : Goal
    {
        private int _amountCompleted;
        private int _target;
        private int _bonus;

        public int GetAmountCompleted()
        {
            return _amountCompleted;
        }
        public int GetTarget()
        {
            return _target;
        }
        public int GetBonus()
        {
            return _bonus;
        }
        
        public ChecklistGoal (string name="", string description="", int points=0, int target=0, int bonus=0) : base (name, description, points)
        {
            _target = target;             
            _bonus = bonus;                         //bonus amount set to begin at 0
        }
        public override void RecordEvent()
        {
            /*Console.WriteLine ("How many times does this goal need to be accomplished for a bonus? "); //3
            _target = Console.ReadLine();
            Console.WriteLine ("What is the bonus for accomplishing it that many times? ");       //500
            _bonusPoints = Console.ReadLine();    */

        }
        public override bool IsComplete()            //when complete how many times the goal set
        {                                             
            
            //if (_target == _amountCompleted)
            //{
            //  return true; 
            //}         
            
        }
        
        public override string GetDetailsString()
        {
            return $"{_isComplete} {_shortName} ({_description})";    // plus the number of times the goal has been accomplished so far.
        }
        public override string GetStringRepresentation()
        {
            return $"{_isComplete} {_shortName} ({_description}) {_points} {_target} {_bonus};             // all details of a goal - easy to save to a file, then load later
        }
    }
}





/*
What is the name of your goal?
What is a short description of it?
What is the amount of points associated with this goal?  50
How many times does this goal need to be accomplished for a bonus? 3
What is the bonus for accomplishing it that many times? 500

*/