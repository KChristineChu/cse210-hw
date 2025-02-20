using System;

public class Running : Activity
{
    private float _distance;
    
    /*public float Distance
    {
        get{return _distance;}
        //set{_distance = value;}
    }*/

     
    public Running(DateTime date, int duration, float distance): base (date, duration)
    {
        _distance = distance;
    }

    public override float GetDistance()
    {
        return _distance;             
    }
    public override float GetPace()
    {
        return Duration / _distance;
    }
    public override float GetSpeed()
    {
        return _distance / Duration * 60;     
    }
}