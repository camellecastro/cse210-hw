using System;
using System.Collections.Generic;

public class Dog : Pet
{
    private List<string> _activities = new List<string>();
    public Dog (string name, string breed) : base (name, breed)
    {
        _activities.Add($"{_name} the {breed} wiggles its tail and played fetch!");
        _activities.Add($"{_name} the {breed} barks and rolled over!");
        _activities.Add($"{_name} the {breed} gave a high-five with its paw!");
        _activities.Add($"{_name} the {breed} jump through a hooop!");
        _activities.Add($"{_name} the {breed} balanced a treat on its nose beefore eating it.");
    }
    public override string Activity()
    {
        Random _random = new Random();
        int index = _random.Next(_activities.Count);
        return _activities[index];
    }
    public override string PetDetails()
    {
        return $"{_name} (The {_breed} Dog)\nHealth: {_health}\nHunger: {_hunger}\nHappiness: {_happiness}";
    }
    public override string PetDetailsStringRepresentation()
    {
        return $"Dog|{_name}|{_breed}|{_health}|{_hunger}|{_happiness}";
    }
}