using System;

public class Bird : Pet
{
    private List<string> _activities = new List<string>();

    public Bird (string name, string breed) : base (name, breed)
    {
        _activities.Add($"{_name} the {breed} speaks and mimic sounds!");
        _activities.Add($"{_name} the {breed} stacks rings on a peg!");
        _activities.Add($"{_name} the {breed} spins around on a perch");
        _activities.Add($"{_name} the {breed} stepped up on your hand!");
        _activities.Add($"{_name} the {breed} danced when the music played.");
    }

    public override string Activity()
    {
        Random _random = new Random();
        int index = _random.Next(_activities.Count);
        return _activities[index];
    }
    public override string PetDetails()
    {
        return $"{_name} (The {_breed} Bird)\nHealth: {_health}\nHunger: {_hunger}\nHappiness: {_happiness}";
    }
    public override string PetDetailsStringRepresentation()
    {
        return $"Bird|{_name}|{_breed}|{_health}|{_hunger}|{_happiness}";
    }
}