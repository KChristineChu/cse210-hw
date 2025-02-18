using System;
using System.Data.SqlTypes;

namespace EternalQuest
{
    public class SimpleGoal : Goal
    {
        protected bool _isComplete = false;

        public SimpleGoal(string name="", string description="", int points = 0, bool IsComplete = false) : base (name, description, points)
        {
            
            _isComplete = IsComplete;
        }

        public override void RecordEvent()
        {
            _isComplete = true;
            return;
            // {
            //    Console.WriteLine(_points);
            //    //Console.WriteLine(GetPoints());
            // }  
        }
       public override bool IsComplete()
        {
                      
            return _isComplete;
        }

        public override string GetStringRepresentation()
        {
            return $"{_shortName} {_description} {_points}";
            //return $"{GetShortName()} {GetDescription()} {GetPoints()}";
        }
        
    }
}

/*if (_isComplete == false)                              
            {
                Console.Write("[ ]");
            }
            else
            {
                Console.Write("[x]");
            }*/