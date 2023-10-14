using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        // Add your logic here for recording the event
        // For example, increment the amount completed and add points based on the current status
        _amountCompleted++;
        if (_amountCompleted < _target)
        {
            _points += 50; // Example: Add 50 points each time the goal is recorded
        }
        else if (_amountCompleted == _target)
        {
            _points += _bonus; // Example: Add a bonus when the target is reached
        }
    }
    public override bool IsComplete()
    {
        return _amountCompleted == _target;
    }
    public override string GetDetailsString()
    {
        return $"[ ] {_shortName} - {_description} (Completed {_amountCompleted}/{_target} times)";
    }
    public override string GetStringRepresentation()
    {
        return $"{GetGoalType()}|{_shortName}|{_description}|{_points}|{_target}|{_bonus}|{_amountCompleted}";
    }
    protected override int GetGoalType()
    {
        return 3;
    }
}