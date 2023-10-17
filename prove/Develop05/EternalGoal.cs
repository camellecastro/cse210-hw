using System;

public class EternalGoal : Goal
{
    private int _eventCounter; // Counter to keep track of how many times the goal is recorded

    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        _eventCounter = 0; // Initialize the event counter to 0
    }

    public override int RecordEvent()
    {
        _eventCounter++; // Count every event accomplished
        Console.WriteLine($"Congratulations! You've earned {_points} points for accomplishing your eternal goal for {_eventCounter} times.");
        return _points; // Return the points earned for each event
    }
    public override bool IsComplete()
    {
        return false; //never considered complete
    }
    public override string GetDetailsString()
    {
        string completionStatus = IsComplete() ? "[X]" : "[ ]";
        return $"{completionStatus} {_shortName} ({_description}) : Completed {_eventCounter} times";
    }
    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{_shortName}|{_description}|{_points}|{_eventCounter}"; 
    }
    public void SetAmountCompleted(int amountCompleted)
    {
        _eventCounter = amountCompleted;
    }
}