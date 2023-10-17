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
    public override int RecordEvent()
    {
        // Increment the amount completed
        _amountCompleted ++;
        
        if (_amountCompleted == _target)
        {
            _points += _bonus; // Add bonus points when the target is reached
            Console.WriteLine($"Congratulations! You've earned {_points} points and a bonus for {_bonus} points.");
            return _bonus; // Return the bonus points
        }
        int _count = _target - _amountCompleted;
        Console.WriteLine($"Congratulations! You've earned {_points} points. You have to do it for {_count} more time for your bonus.");
        return _points; // Return the regular points if the target is not reached
    }
    public override bool IsComplete()
    {
        return _amountCompleted == _target;
    }
    public override string GetDetailsString()
    {
        string completionStatus = IsComplete() ? "[X]" : "[ ]";
        return $"{completionStatus} {_shortName} ({_description}) : Completed {_amountCompleted}/{_target}";
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_amountCompleted}|{_target}|{_bonus}";
    }
    public void SetAmountCompleted(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }
}