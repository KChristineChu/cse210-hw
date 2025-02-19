using System;
using System.Data;


public abstract class Activity
    {
        protected DateTime _date;
        protected int _duration;

        public Activity (DateTime date, int duration)
        {
            _date = date;
            _duration = duration;
        }

        public abstract float GetDistance();

        public abstract float GetSpeed();
        public abstract float GetPace();
        
    }    
    
    
    
