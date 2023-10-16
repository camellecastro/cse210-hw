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
        // Mark the simple goal as complete and return the points
        if (_isComplete == 0)
        {
            _isComplete = 1; // Mark the simple goal as complete
            return _points; // Return the points earned
        }
        return 0; // Return 0 if the goal is already complete
    }
    public override bool IsComplete()
    {
        // return _isComplete;
        return _isComplete > 0;
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{_shortName}|{_description}|{_points}|{_isComplete}";
    }
}