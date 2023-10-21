using System;
using System.Collections.Generic;
using System.IO;

public class Menu
{
    private List<Pet> _pets;
    private string _userName;
    public Menu()
    {
        _pets = new List<Pet>();
        _userName = "Default";
    }

    public void Start()
    {
        Console.Clear();

        Console.WriteLine("Welcome to the Virtual Pet Simulator Game!");
        Console.WriteLine("\nPress 1 for a New Game");
        Console.WriteLine("Press 2 to Load Game\n");
        string _choice = Console.ReadLine();

        Console.Clear();
        if (_choice == "1")
        {
            
            Console.Write("Hello there! To begin your pet owner journey. What name should we call you? ");
            _userName = Console.ReadLine();

            Console.Clear();

            Console.WriteLine($"Hello {_userName}! Get ready to embark on an exciting journey of pet ownership. Adopt, feed, and play with your virtual pets. It's time to nurture your virtual pet and watch it thrive. Let the adventure begin!");
        }
        else if (_choice == "2")
        {
            Console.Write("\nTo load past game, please enter the filename: ");
            string _fileName = Console.ReadLine();
            LoadGame(_fileName);
        }

        while (true)
        {
            Console.WriteLine($"\nVirtual Pet Simulator Game");
            DisplayPetOwnerInfo();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Adopt Pet");
            Console.WriteLine("2. Feed Pet");
            Console.WriteLine("3. Play with Pet");
            Console.WriteLine("4. Check Pet Status");
            Console.WriteLine("5. Petshow");
            Console.WriteLine("6. Save Game"); 
            Console.WriteLine("7. Quit");

            Console.Write("\nSelect a choice from the menu: ");
            string _userChoice = Console.ReadLine();

            while (true)
            {
                if (_userChoice == "1")
                {
                    AdoptPet();
                    break;
                }
                else if (_userChoice == "2")
                {
                    
                    FeedPet();
                    break;
                }
                else if (_userChoice == "3")
                {
                    PlayWithPet();
                    break;
                }
                else if (_userChoice == "4")
                {
                    ViewPetStatus();
                    break;
                }
                else if (_userChoice == "5")
                {
                    PetShow petShow = new PetShow(_pets);
                    petShow.InitializePetsActivity();
                    break;
                }
                else if (_userChoice == "6")
                {
                    Console.Write("\nSave file to (enter filename): ");
                    string saveFileName = Console.ReadLine();
                    SaveGame(saveFileName);
                    break;
                }
                else if (_userChoice == "7")
                {
                    Environment.Exit(0);
                    break;
                }
                else 
                {
                    Console.WriteLine("\nInvalid choice. Please select a valid option.");
                    break;
                }     
            }
        }
    }

    public void DisplayPetOwnerInfo()
    {
        Console.WriteLine($"\nPet Owner: {_userName}\n");
    }

    public void ViewPetStatus()
    {
        DisplayPetOwnerInfo();
        Console.WriteLine("\nPets:\n");
        for (int i = 0; i < _pets.Count; i++)
        {
            Console.Write($"Pet {i + 1}: ");
            Console.WriteLine(_pets[i].PetDetails());
        }
    }

    public void AdoptPet()
    {
        Console.Clear();
        Console.WriteLine("\nPets available for adoption:\n");
        Console.WriteLine("1. Dog");
        Console.WriteLine("2. Cat");
        Console.WriteLine("3. Bird");
        Console.WriteLine("4. Fish");
        Console.Write("\nWhich pet would you like to adopt? (Dog, Cat, Bird, Fish, Reptile)\n-- ");

        string _petType = Console.ReadLine();

        Console.Write("Enter pet's name: ");
        string _petName = Console.ReadLine();
        Console.Write("Enter pet's breed: ");
        string _petBreed = Console.ReadLine();

        User newUser = new User(_userName);

        if (_petType.Equals("Dog", StringComparison.OrdinalIgnoreCase))
        {

            Dog _adoptedPet = new Dog(_petName, _petBreed);
            newUser.AdoptPet(_adoptedPet, _petName, _petBreed);
            _pets.Add(_adoptedPet);
        }
        else if (_petType.Equals("Cat", StringComparison.OrdinalIgnoreCase))
        {
            Cat _adoptedPet = new Cat(_petName, _petBreed);
            newUser.AdoptPet(_adoptedPet, _petName, _petBreed);
            _pets.Add(_adoptedPet);
        }
        else if (_petType.Equals("Bird", StringComparison.OrdinalIgnoreCase))
        {
            Bird _adoptedPet = new Bird(_petName, _petBreed);
            newUser.AdoptPet(_adoptedPet, _petName, _petBreed);
            _pets.Add(_adoptedPet);
        }
        else if (_petType.Equals("Fish", StringComparison.OrdinalIgnoreCase))
        {
            Fish _adoptedPet = new Fish(_petName, _petBreed);
            newUser.AdoptPet(_adoptedPet, _petName, _petBreed);
            _pets.Add(_adoptedPet);
        }
        else if (_petType.Equals("Reptile", StringComparison.OrdinalIgnoreCase))
        {
            Reptile _adoptedPet = new Reptile(_petName, _petBreed);
            newUser.AdoptPet(_adoptedPet, _petName, _petBreed);
            _pets.Add(_adoptedPet);
        }
        else
        {
            Console.WriteLine($"\nSorry {_userName}, there's no {_petBreed} {_petType} pet ready for adoption at the moment.");
        }
    }

    public void FeedPet()
    {
        ViewPetStatus();
        Console.Write("\nWhich pet would you like to feed? (1 to " + _pets.Count + "): ");
        int petIndex = int.Parse(Console.ReadLine()) - 1;

        if (petIndex >= 0 && petIndex < _pets.Count)
        {
            Pet selectedPet = _pets[petIndex];
            User _user = new User(_userName);
            _user.FeedPet(selectedPet);
        }
        else
        {
            Console.WriteLine("Invalid pet selection.");
        }
    }
    public void PlayWithPet()
    {
        ViewPetStatus();
        Console.Write("\nWhich pet would you like to play with? (1 to " + _pets.Count + "): ");
        int petIndex = int.Parse(Console.ReadLine()) - 1;

        if (petIndex >= 0 && petIndex < _pets.Count)
        {
            Pet selectedPet = _pets[petIndex];
            User _user = new User(_userName);
            _user.PlayWithPet(selectedPet);
        }
        else
        {
            Console.WriteLine("Invalid pet selection.");
        }
    }
    

    public void SaveGame(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            Console.WriteLine("\nSaving game . . .\n");
            outputFile.WriteLine(_userName);
            foreach (Pet pet in _pets)
            {
                outputFile.WriteLine(pet.PetDetailsStringRepresentation());
            }
            Console.WriteLine("\nGame saved!");
        }
    }
    
    public void LoadGame(string filename)
    {
        Console.WriteLine($"\nLoading game files from {filename} . . .\n");
        _pets.Clear();
        string[] lines = System.IO.File.ReadAllLines(filename);

        if (lines.Length > 0)
        {
            _userName = lines[0];
        }

        // Start parsing goal data from line 1 (skip the score line)
        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split("|");

            //"Dog|{_name}|{_breed}|{_health}|{_hunger}|{_happiness}";
            //Dog,Cat,Bird,Fish
            string type = parts[0];
            string name = parts[1];
            string breed = parts[2];
            int health = int.Parse(parts[3]);
            int hunger = int.Parse(parts[4]);
            int happiness = int.Parse(parts[5]);

            if (type == "Dog")
            {
                Pet pet = new Dog(name, breed);
                _pets.Add(pet); 
            }

            else if (type == "Cat")
            {
                Pet pet = new Cat(name, breed);
                _pets.Add(pet); 
            }
            else if (type == "Bird")
            {
                Pet pet = new Bird(name, breed);
                _pets.Add(pet); 
            }
            else if (type == "Fish")
            {
                Pet pet = new Fish(name, breed);
                _pets.Add(pet); 
            }   
            else if (type == "Reptile")
            {
                Pet pet = new Reptile(name, breed);
                _pets.Add(pet); 
            }            
        }
        Console.WriteLine($"Game is successfully loaded from '{filename}'.\n");
    }
}