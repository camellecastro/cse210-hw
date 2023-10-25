using System;
using System.Collections.Generic;

public class Reptile : Pet
{
    private List<string> _activities = new List<string>();
    public Reptile (string name, string breed) : base (name, breed)
    {
        _activities.Add($"{_name} the {breed} showcase its climbing ability and agility in the obstacle course that you've created.");
        _activities.Add($"{_name} the {breed} highlights its natural behavior, basking under a heat lamp.");
        _activities.Add($"{_name} the {breed} shows stillness, it almost look like a detailed artpiece.");
    }
    public override string Activity()
    {
        Random _random = new Random();
        int index = _random.Next(_activities.Count);
        return _activities[index];
    }
    public override string PetDetails()
    {
        return $"{_name} (The {_breed} Reptile)\nHealth: {_health}\nHunger: {_hunger}\nHappiness: {_happiness}";
    }
    public override string PetDetailsStringRepresentation()
    {
        return $"Reptile|{_name}|{_breed}|{_health}|{_hunger}|{_happiness}";
    }
}