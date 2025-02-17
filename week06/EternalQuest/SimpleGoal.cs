using System;
using System.Data.SqlTypes;

namespace EternalQuest
{
    public class SimpleGoal : Goal
    {
        private bool _isComplete = false;

        public SimpleGoal(string name="", string description="", int points = 0, bool IsComplete = false) : base (name, description, points)
        {
            
            _isComplete = IsComplete;
        }

        public override void RecordEvent()
        {
            if(_isComplete == true)
            {
               Console.WriteLine(_points);
               //Console.WriteLine(GetPoints());
            }
                
        }
       public override bool IsComplete()
        {
                      
            /*if (_isComplete == false)                              //return false;
            {
                Console.Write("[ ]");
            }
            else
            {
                Console.Write("[x]");
            }*/
            return _isComplete;
        }

        public override string GetStringRepresentation()
        {
            return $"{_shortName} {_description} {_points}";
            //return $"{GetShortName()} {GetDescription()} {GetPoints()}";
        }
        
    }
}