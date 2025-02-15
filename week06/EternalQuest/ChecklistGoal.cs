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
        
        public ChecklistGoal (string name, string description, int points, int target, int bonus) : base (name, description, points)
        {
            _target = target;
            _bonus = bonus;
        }
        public override void RecordEvent()
        {

        }
        public override bool IsComplete()
        {
            
        }
        
        public string GetDetailsString()
        {

        }
        public string GetStringRepresentation()
        {

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