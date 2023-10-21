using System;

public abstract class Pet
{
    protected string _name;
    protected string _breed;
    protected int _health;
    protected int _hunger;
    protected int _happiness;

    public Pet(string name, string breed)
    {
        Random random = new Random();
        _name = name;
        _breed = breed;
        _health = 60;
        _hunger = 60;
        _happiness = 60;
    }

    public void Feed()
    {
        _health += 5;
        _happiness += 5;
        _hunger -= 10;
        if (_hunger < 0)
        {
            _hunger = 0;
        }
        if (_health > 100)
        {
            _health = 100;
        }
        if (_happiness > 100)
        {
            _health = 100;
        }      
        Console.WriteLine($"{_name} has been fed.");
    }
    public void Play()
    {
        _health += 3;
        _hunger += 5;
        _happiness += 8;
        if (_happiness > 100)
        {
            _happiness = 100;
        }
        if (_health > 100)
        {
            _health = 100;
        }    
        Console.WriteLine($"{_name} is happy and playful.");
    }
    public abstract string Activity();
    public virtual string PetDetails()
    {
        return $"{_name} ({_breed})\nHealth: {_health}\nHunger: {_hunger}\nHappiness: {_happiness}";
    }
    public abstract string PetDetailsStringRepresentation();
}