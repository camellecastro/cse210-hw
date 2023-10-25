using System;
using Microsoft.VisualBasic;

public class User
{
    private string _name;
    public User(string name)
    {
        _name = name;
    }

    public void AdoptPet(Pet pet, string name, string breed)
    {
        Console.WriteLine($"\n{_name} you successfully adopted a {breed} {pet}!");
        Console.WriteLine($"{name} the {breed} {pet} is now your pet.");
    } 
    public void FeedPet(Pet pet)
    {
        pet.Feed();
    }
    public void PlayWithPet(Pet pet)
    {
        pet.Play();
    }
}