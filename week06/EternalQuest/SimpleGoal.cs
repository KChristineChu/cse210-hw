using System;
using System.Data.SqlTypes;

namespace EternalQuest
{
    public class SimpleGoal : Goal
    {
        private bool _isComplete;

        public SimpleGoal(string name, string description, int points) : base (name, description, points)
        {
            

        }

        public override void RecordEvent()
        {

        }
        public override bool IsComplete()
        {
            if (_isComplete == true)
            return "[X]";
        }
            else
            {
                return "[]";
            }

        public override string GetStringRepresentation()
        {
            return "";
        }
        
    }
}