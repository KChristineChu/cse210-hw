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

        public string GetSummary()
        {
            return $"{_date.ToString("dd MMM yyyy")} ({Duration} min) - Distance {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
        }
        
    }    
    
    
    
