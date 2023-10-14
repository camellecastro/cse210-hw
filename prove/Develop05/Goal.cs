using System;
using System.Collections.Generic;
using System.IO;
public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal()
    {
        _shortName = "Name";
        _description = "Description";
        _points = 0;
    }

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        string completionStatus = IsComplete() ? "[X]" : "[ ]";
        return $"{completionStatus} {_shortName} - {_description}";
    }
    public abstract string GetStringRepresentation();

    //to know goal type if its simple, eternal, or checklist
    protected virtual int GetGoalType()
    {
        return 0;
    }
    public virtual int GetPoints()
    {
        return _points;
    }
}