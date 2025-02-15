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
    /*public void SetShortName(string shortName)
    {
        _shortName = shortName;
    }*/
    public string GetDescription()
    {
        return _description;
    }
    /*public void SetDescription(string description)
    {
        _description = description;
    }*/
    public int GetPoints()
    {
        return _points;
    }
    /*public void SetPoints(int points)
    {
        _points = points;
    }*/

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent()
    {
        Console.WriteLine("What is the name of your goal? ");
        _shortName = Console.ReadLine();
        Console.WriteLine("What is a short description of it? ");
        _description = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal? ");  
        _points = Console.ReadLine();

        Console.WriteLine ("How many times does this goal need to be accomplished for a bonus? ");
        _number = Console.ReadLine();
        Console.WriteLine ("What is the bonus for accomplishing it that many times? "); 
        _bonusPoints = Console.ReadLine();
    }


    public abstract bool IsComplete();

    public string GetDetailsString()
    {
        return "";
    }
    public abstract string GetStringRepresentation();
    
}

/*
Same set of questions for option 1 choice 1 Simple Goal, 2 Eternal 3 Checklist: Each reply will be stored
Console.WriteLine("What is the name of your goal? ")
_shortName = Console.ReadLine();
Console.WriteLine("What is a short description of it? ")
_description = Console.ReadLine();
Console.WriteLine("What is the amount of points associated with this goal? ");  50
_points = Console.ReadLine();
Console.WriteLine ("How many times does this goal need to be accomplished for a bonus? "); 3
_number = Console.ReadLine();
Console.WriteLine ("What is the bonus for accomplishing it that many times? ); 500
_bonusPoints = Console.ReadLine();
*/