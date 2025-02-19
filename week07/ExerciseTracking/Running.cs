using System;

public class Running : Activity
{
    protected float _distance;
     
    public Running(DateTime date, int duration, float distance): base (date, duration)
    {
        _distance = distance;
    }

    public override float GetDistance()
    {
        return 0;              //add later
    }
    public override float GetPace()
    {
        return 0;
    }
    public override float GetSpeed()
    {
        return 0;
    }
}