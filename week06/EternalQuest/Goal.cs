using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;               //string?

    public string GetShortName()
    {
        return _shortName;
    }
    public void SetShortName(string shortName)
    {
        _shortName = shortName;
    }
    public string GetDescription()
    {
        return _description;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public int GetPoints()
    {
        return _points;
    }
    public void SetPoints(int points)
    {
        _points = points;
    }

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public string GetDetailsString()
    {
        return "";
    }
    public abstract string GetStringRepresentation();
    
}

/*
What is the name of your goal?
What is a short description of it?
What is the amount of points associated with this goal?  50
How many times does this goal need to be accomplished for a bonus? 3
What is the bonus for accomplishing it that many times? 500

*/