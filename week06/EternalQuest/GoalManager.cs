using System;

public class GoalManager 
{
    private List<Goal> _goal;
    private int _score;

    public List<Goal> GetGoal()
    {
        return _goal;
    }
    public int GetScore()
    {
        return _score;
    }

    public GoalManager (List<Goal> goal, int score)
    {
        _goal = goal;
        _score = score;
    }

    public void Start()
    {

    }
    public void DisplayPlayerInfo()
    {

    }
    public void ListGoalNames()
    {

    }
    public void ListGoalDetails()
    {

    }
    public void CreateGoal()
    {
        Console.WriteLine("What is the name of your goal? ");
        _shortName = Console.ReadLine();

    }
    public void RecordEvent()
    {

    }
    public void SaveGoals()
    {

    }
    public void LoadGoals()
    {

    }
}


    
