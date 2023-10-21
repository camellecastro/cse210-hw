using System;

public class Fish : Pet
{
    private List<string> _activities = new List<string>();

    public Fish(string name, string breed) : base (name, breed)
    {
        _activities.Add($"{_name} the {breed} swim through the obstacle course inside its tank!");
        _activities.Add($"{_name} the {breed} amusingly interacts with its reflection when placed a mirror on the outside of its tank");
        _activities.Add($"{_name} the {breed} swims up to grab floating food pellets.");
        _activities.Add($"{_name} the {breed} swims around its tank.");
    }

    public override string Activity()
    {
        Random _random = new Random();
        int index = _random.Next(_activities.Count);
        return _activities[index];
    }
    public override string PetDetails()
    {
        return $"{_name} (The {_breed} Fish)\nHealth: {_health}\nHunger: {_hunger}\nHappiness: {_happiness}";
    }
    public override string PetDetailsStringRepresentation()
    {
        return $"Fish|{_name}|{_breed}|{_health}|{_hunger}|{_happiness}";
    }
}