using System;

public class EternalGoal : Goal
{
    private int _eventCounter; // Counter to keep track of how many times the goal is recorded

    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        _eventCounter = 0; // Initialize the event counter to 0
    }

    public override void RecordEvent()
    {
        _eventCounter++; //count every event accomplished
        // _points += _points;
    }
    public override bool IsComplete()
    {
        return false; //never considered complete
    }
    public override string GetDetailsString()
    {
        string completionStatus = IsComplete() ? "[X]" : "[ ]";
        return $"{completionStatus} {_shortName} - {_description}. Completed {_eventCounter} times";
    }
    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{_shortName}|{_description}|{_points}|{_eventCounter}"; 
    }
    public override int GetPoints()
    {
        return _points;
    }
    public void SetAmountCompleted(int amountCompleted)
    {
        _eventCounter = amountCompleted;
    }

}