using System;

namespace EternalQuest
{
    public class EternalGoal : SimpleGoal
    {
        public EternalGoal (string name="", string description="", int points=0) : base (name, description, points)
        {

            //_name = name;
            //_description = description;
            //_points = points;

        } 
        public override void RecordEvent()
        {
            if(_isComplete == true)
            {
               Console.WriteLine(_points);
            }
        }
        public override bool IsComplete()              //not mark with X
        {
            return _isComplete;
        }
        public override string GetStringRepresentation()
        {
            return $"{_shortName} {_description} {_points}";
        }
 
    }

}   
