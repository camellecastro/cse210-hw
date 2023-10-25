using System;

public abstract class Pet
{
    protected string _name;
    protected string _breed;
    protected int _health;
    protected int _hunger;
    protected int _happiness;
    public User _user;

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
        Console.WriteLine($"\n{_name} has been fed.");
    }
    public void Play()
    {
        _health += 3;
        _hunger += 5;
        _happiness += 8;
        // Ensure the health, hunger, and happiness values stay within their limits.
        if (_happiness > 100)
        {
            _happiness = 100;
        }
        if (_health > 100)
        {
            _health = 100;
        }
        if (_hunger < 0)
        {
            _hunger = 0;
        }

        Console.WriteLine($"\n{_name} is happy and playful.");
    }
    public void SetHealth(int health)
    {
        _health = health;
    }

    public void SetHunger(int hunger)
    {
        _hunger = hunger;
    }

    public void SetHappiness(int happiness)
    {
        _happiness = happiness;
    }
    public bool IsDead()
    {
        return _hunger >= 100;
    }
    public void DeathStatus()
    {
        Console.WriteLine($"\nNotification:");
        Console.WriteLine($"\nOh no! Your {_breed} pet {_name}, though healthy and happy, has died due to extreme hunger.\n");
    }
    public abstract string Activity();
    public virtual string PetDetails()
    {
        return $"{_name} ({_breed})\nHealth: {_health}\nHunger: {_hunger}\nHappiness: {_happiness}4";
    }
    public abstract string PetDetailsStringRepresentation();
}