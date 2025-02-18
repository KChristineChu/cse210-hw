using System;

namespace EternalQuest
{
    

    public class ChecklistGoal : Goal
    {
        protected int _amountCompleted;
        protected int _target;
        protected int _bonus;
        protected bool _isComplete;

        public ChecklistGoal (string name="", string description="", int points=0, int target=0, int bonus=0, bool _isComplete=false) : base (name, description, points)
        {
            _target = target;             
            _bonus = bonus;                         //bonus amount set to begin at 0
        }

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
        
    
        public override void RecordEvent()
        {
            //Console.WriteLine ("How many times does this goal need to be accomplished for a bonus? "); //3
            //_target = Console.ReadLine();
            //Console.WriteLine ("What is the bonus for accomplishing it that many times? ");       //500
            //_bonusPoints = Console.ReadLine();    
            // if amount == target
            //  getBonus = True;

        } 
    
        
        public override bool IsComplete()            //when complete how many times the goal set
        {                                             
            
            if (_target == _amountCompleted)
            {
              return true; 
            }         
            else{
                return false;
            }
        }
        
        public override string GetDetailsString()
        {
            //return $"{_isComplete} {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";    // plus the number of times the goal has been accomplished so far.
            return $" {_shortName} {_description} -- Currently completed: {_amountCompleted}/{_target}";
        }
        public override string GetStringRepresentation()
        {
            return $"{_isComplete} {_shortName} ({_description}) {_points} {_target} {_bonus}";             // all details of a goal - easy to save to a file, then load later
        } 
        
    }
    
}








