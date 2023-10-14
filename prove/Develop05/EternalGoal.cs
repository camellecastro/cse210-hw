using System;

public class EternalGoal : Goal
{
    private int eventCounter; // Counter to keep track of how many times the goal is recorded

    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        eventCounter = 0; // Initialize the event counter to 0
    }

    public override void RecordEvent()
    {
        eventCounter++; //count every event accomplished
        // _points += _points;
    }
    public override bool IsComplete()
    {
        return false; //never considered complete
    }
    public override string GetDetailsString()
    {
        string completionStatus = IsComplete() ? "[X]" : "[ ]";
        return $"{completionStatus} {_shortName} - {_description}. Completed {eventCounter} times";
    }
    public override string GetStringRepresentation()
    {
        return $"{GetGoalType()}|{_shortName}|{_description}|{_points}|{eventCounter}"; 
    }
    protected override int GetGoalType()
    {
        return 2;
    }
    public override int GetPoints()
    {
        return _points;
    }

}