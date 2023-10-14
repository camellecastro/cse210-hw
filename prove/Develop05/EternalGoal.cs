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
        eventCounter++;
        _points += _points;
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetStringRepresentation()
    {
        return $"{GetGoalType()}|{_shortName}|{_description}|{_points}|{eventCounter}";
    }
    protected override int GetGoalType()
    {
        return 2;
    }

}