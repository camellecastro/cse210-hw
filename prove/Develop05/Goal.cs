using System;
using System.Collections.Generic;
using System.IO;
public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

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
        // string completionStatus = IsComplete() ? "[X]" : "[ ]";
        // return $"{completionStatus} {_shortName} - {_description}";
        return $"[ ] {_shortName} - {_description}";
    }
    public abstract string GetStringRepresentation();

    //to know goal type if its simple, eternal, or checklist
    public virtual int GetPoints()
    {
        return _points;
    }
}