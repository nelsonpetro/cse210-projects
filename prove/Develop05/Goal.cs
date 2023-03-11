using System;

public abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;
    private bool _isComplete;
    
    public Goal(string name, string description, int points)
    {
        name = "";
        description = "";
        points = 0;
    }

    public abstract void CreateGoal();

    public abstract void IsComplete();

    public virtual int GetTotalTimes()
    {
        return 0;
    }

    public virtual int GetPartialTimes()
    {
        return 0;
    }

    public virtual int GetBonus()
    {
        return 0;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
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

    public void SetIsComplete(bool isComplete)
    {
        _isComplete = isComplete;
    }

    public bool GetIsComplete()
    {
        return _isComplete;
    }

    public void SetPoints(int points)
    {
        _points = points;
    }
}