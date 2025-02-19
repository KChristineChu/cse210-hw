using System;

public class Cycling : Activity
{
    protected float _speed;

    public Cycling (DateTime date, int duration, float speed) : base (date, duration)
    {
        _speed = speed;
    }

    public override float GetDistance()
    {
        return 0;
    }
    public override float GetSpeed()
    {
        return 0;
    }
    public override float GetPace()
    {
        return 0;
    }

}