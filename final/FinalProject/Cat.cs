using System;

public class Cat : Pet
{
    private List<string> _activities = new List<string>();

    public Cat (string name, string breed) : base (name, breed)
    {
        _activities.Add($"{_name} the {breed} meows and played fetch!");
        _activities.Add($"{_name} the {breed} showed its learned skill in target training!");
        _activities.Add($"{_name} the {breed} meows and spins around!");
        _activities.Add($"{_name} the {breed} balanced on a rope!");
        _activities.Add($"{_name} the {breed} sit on command and gave a paw shake.");
    }
    public override string Activity()
    {
        Random _random = new Random();
        int index = _random.Next(_activities.Count);
        return _activities[index];
    }
    public override string PetDetails()
    {
        return $"{_name} (The {_breed} Cat)\nHealth: {_health}\nHunger: {_hunger}\nHappiness: {_happiness}";
    }
    public override string PetDetailsStringRepresentation()
    {
        return $"Cat|{_name}|{_breed}|{_health}|{_hunger}|{_happiness}";
    }
}