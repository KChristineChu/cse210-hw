using System;
public class Swimming : Activity
{
    protected int _lap;

    public Swimming (DateTime date, int duration, int lap) : base (date, duration)
    {
        _lap = lap;
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