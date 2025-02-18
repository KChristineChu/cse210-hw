using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace EternalQuest
{
    public abstract class Goal
    {
    //private string _shortName;
    protected string _shortName;
    //private string _description;
    protected string _description;
    //private int _points;      
    protected int _points;                 
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
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

    

    public abstract void RecordEvent();            //no body, or empty body
    // This method should do whatever is necessary for each specific kind of goal, 
    // such as marking a simple goal complete and adding to the number of times a checklist goal has been completed. 
    // It should return the point value associated with recording the event (keep in mind that it may contain a bonus in some cases if a checklist goal was just finished, for example).


    public abstract bool IsComplete();
    //This method should return true if the goal is completed. 
    //The way you determine if a goal is complete is different for each type of goal.

    public virtual string GetDetailsString()                 // abstract? - no
    {
        return $" {_shortName} ({_description})";
    }
    public abstract string GetStringRepresentation();
    
    }

}



