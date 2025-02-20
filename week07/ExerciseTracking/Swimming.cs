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
        return _lap * 50 / 1000;
    }
    public override float GetSpeed()
    {
        return GetDistance() / Duration * 60;
    }
    public override float GetPace()
    {
        return Duration / GetDistance();
    }
    public override string GetActivityName()
        {
            return "Swimming";
        }

}