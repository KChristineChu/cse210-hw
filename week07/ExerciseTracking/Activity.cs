using System;
using System.Data;


public abstract class Activity
    {
        private DateTime _date;
        private int _duration;

        public DateTime Date
        {
            get{return _date;}
        }
        public int Duration
        {
            get{return _duration;}
        }

        public Activity (DateTime date, int duration)
        {
            _date = date;
            _duration = duration;
        }

        public abstract float GetDistance();

        public abstract float GetSpeed();
        public abstract float GetPace();

        public abstract string GetActivityName();


        public string GetSummary()
        {
            return $"{_date.ToString("dd MMM yyyy")} {GetActivityName()} ({Duration} min) - Distance {GetDistance():0.0} km, Speed: {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min per km";
        }
        
    }    
    
    
    
