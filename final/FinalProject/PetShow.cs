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

        int actNumber = 1; // Initialize the act number

        foreach (Pet pet in _userAdoptedPets)
        {
            string activity = pet.Activity();
            Console.WriteLine($"Act {actNumber}: {activity}");
            actNumber++; // Increment the act number for the next activity
        }

        Console.WriteLine("\nPetshow ended.");
    }
}