using System;
using System.Collections.Generic;

public class PetShow
{
    private List<Pet> _userAdoptedPets; // Store the user's adopted pets

    public PetShow(List<Pet> userAdoptedPets)
    {
        _userAdoptedPets = userAdoptedPets;
    }

    public void InitializePetsActivity()
    {
        Console.WriteLine("\nPet Show Activities:\n");
        foreach (Pet pet in _userAdoptedPets)
        {
            string activity = pet.Activity();
            Console.WriteLine($"Act 1: {activity}");
        }
    }
}