using System;

public class SimpleGoal : Goal
{
    private int _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = 0;
    }

    public override int RecordEvent()
    {
        _isComplete = 1;
        Console.WriteLine($"Congratulations! You've earned {_points} points for accomplishing that goal.");
        return _points;
    }
    public override bool IsComplete()
    {
        return _isComplete > 0;
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{_shortName}|{_description}|{_points}|{_isComplete}";
    }
}