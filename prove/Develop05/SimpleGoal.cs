using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        // Mark the simple goal as complete and return the points
        if (!_isComplete)
        {
            _isComplete = true;
            _points += _points;
            // You can optionally provide points here
        }
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetStringRepresentation()
    {
        return $"{GetGoalType()}|{_shortName}|{_description}|{_points}|{_isComplete}";
    }
    protected override int GetGoalType()
    {
        return 1;
    }
}