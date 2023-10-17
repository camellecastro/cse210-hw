// RandomGoal
using System;

public class RandomGoal : Goal
{
    private int _isComplete;
    public RandomGoal(string description) : base("Random Goal", description, 50)
    {
        _isComplete = 0;
    }

    public override int RecordEvent()
    {
        _isComplete = 1;
        Console.WriteLine($"Congratulations! You've earned {_points} points for completing a random goal.");
        return 50;
    }

    public override bool IsComplete()
    {
        return _isComplete > 0;
    }

    public override string GetStringRepresentation()
    {
        return $"RandomGoal|{_shortName}|{_description}|{_points}|{_isComplete}";
    }
}