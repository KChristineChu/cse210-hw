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
        return _speed * Duration / 60;
    }
    public override float GetSpeed()
    {
        return _speed;
    }
    public override float GetPace()
    {
        return 60 / _speed;
    }
    public override string GetActivityName()
        {
            return "Cycling";
        }

}