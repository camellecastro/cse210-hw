using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        while (true)
        {
            Console.WriteLine($"\nEternal Quest");
            Console.WriteLine($"\nYou have {_score} points.\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Random Goal Generator"); // New option to view daily challenges
            Console.WriteLine("7. Quit");

            Console.Write("\nSelect a choice from the menu: ");
            string userChoice = Console.ReadLine();

            while (true)
            {
                if (userChoice == "1")
                {
                    CreateGoal();
                    break;
                }
                else if (userChoice == "2")
                {
                    ListGoalNames();
                    break;
                }
                else if (userChoice == "3")
                {
                    Console.Write("\nSave file to (enter filename): ");
                    string saveFileName = Console.ReadLine();
                    SaveGoals(saveFileName);
                    break;
                }
                else if (userChoice == "4")
                {
                    Console.Write("\nLoad File from (filename): ");
                    string loadFileName = Console.ReadLine();
                    LoadGoals(loadFileName);
                    break;
                }
                else if (userChoice == "5")
                {
                    RecordEvent();
                    break;
                }
                if (userChoice == "6")
                {
                    RandomGoal();
                    break;
                }
                else if (userChoice == "7")
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

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points.");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("\nThe goals are:\n");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.Write($"Goal {i + 1}: ");
            Console.WriteLine(_goals[i].GetDetailsString());
        }
    }

    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetStringRepresentation());
        }
    }

    public void CreateGoal()
    {
        Console.Clear();
        Console.WriteLine("\nThe types of Goals are:\n");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("\nWhich type of goal would you like to create: ");

        string goalType = Console.ReadLine();

        Console.Write("Enter goal title: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter amount of points for this goal: ");
        int points = int.Parse(Console.ReadLine());

        if (goalType == "1")
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (goalType == "2")
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (goalType == "3")
        {
            Console.Write("How many times does this goal need to be accomplished: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write($"Enter amount of bonus points when accomplished {target} times: ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
        else
        {
            Console.WriteLine("Invalid goal type. Goal not created.");
        }
    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("\nSelect a goal to record an event (1 to " + _goals.Count + "): ");
        int goalIndex = int.Parse(Console.ReadLine());

        //adjust the user input to be 0-based
        goalIndex--;

        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            Goal selectedGoal = _goals[goalIndex];
            _score += selectedGoal.RecordEvent();
        }
        else
        {
            Console.WriteLine("Invalid goal selection.");
        }
    }

    public void SaveGoals(string filename)
    {
        
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            Console.WriteLine("\nSaving changes . . .\n");
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
            Console.WriteLine("\nChanges saved!");
        }
    }
    
    public void LoadGoals(string filename)
    {
        Console.WriteLine($"\nLoading goals from {filename} . . .\n");
        _goals.Clear();
        string[] lines = System.IO.File.ReadAllLines(filename);

        if (lines.Length > 0)
        {
            if (int.TryParse(lines[0], out int score))
            {
                _score = score; // Set the player's score from the file
            }
            else
            {
                Console.WriteLine("\nFailed to parse the player's score.\n");
            }
        }

        // Start parsing goal data from line 1 (skip the score line)
        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split("|");

            string type = parts[0];
            string shortName = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);

            if (type == "SimpleGoal")
            {
                SimpleGoal goal = new SimpleGoal(shortName, description, points);

                if (int.TryParse(parts[4], out int isComplete))
                {
                    // Set the IsComplete property based on the parsed integer value
                    if (isComplete == 1)
                    {
                        goal.RecordEvent(); // Mark the SimpleGoal as complete
                    }
                }
                else
                {
                    Console.WriteLine("Failed to parse the IsComplete value.");
                    // Decide how to handle the error, e.g., set a default value.
                }

                _goals.Add(goal); // Add the SimpleGoal to the list
            }

            else if (type == "EternalGoal")
            {
                EternalGoal goal = new EternalGoal(shortName, description, points);
                goal.SetAmountCompleted(int.Parse(parts[4]));
                _goals.Add(goal);
            }
            else if (type == "ChecklistGoal")
            {
                int target = int.Parse(parts[5]);
                int bonus = int.Parse(parts[6]);
                ChecklistGoal goal = new ChecklistGoal(shortName, description, points, target, bonus);
                goal.SetAmountCompleted(int.Parse(parts[4]));
                _goals.Add(goal);
            }
            else
            {
                RandomGoal goal = new RandomGoal(description);
                if (int.TryParse(parts[4], out int isComplete))
                {
                    // Set the IsComplete property based on the parsed integer value
                    if (isComplete == 1)
                    {
                        goal.RecordEvent(); 
                    }
                }
                _goals.Add(goal);
            }
        }
        Console.WriteLine($"\nGoals successfully loaded from '{filename}'.\n");
    }
    // Method to view and complete daily challenges
    public void RandomGoal()
    {
        string random = GenerateRandomGoal(); // Generate a random daily challenge
        Console.WriteLine($"\nRandom Goal: {random}");
        _goals.Add(new RandomGoal(random));
    }

    // Method to generate a random daily challenge (you can customize this as needed)
    public string GenerateRandomGoal()
    {
        string[] prompts = new string[]
        {
            "Clean out your closet and donate unused clothes",
            "Read a book in a single day",
            "Take a 30-minute walk in the park",
            "Try a new recipe for dinner",
            "Write a thank-you note to someone you appreciate",
            "Declutter your desk or workspace",
            "Plant a flower or herb in your garden",
            "Organize your digital photos into folders",
            "Learn a basic magic trick to amuse friends",
            "Try a new fitness class at the gym",
            "Call a friend or family member you haven't spoken to in a while",
            "Create a budget for the month",
            "Write a short poem or story",
            "Visit a museum or art gallery",
            "Take a day trip to a nearby town or city",
            "Learn a few basic yoga poses",
            "Read a chapter of a book",
            "Do 30 minutes of exercise",
            "Learn a new word in a foreign language",
            "Write a journal entry",
            "Practice a musical instrument for 15 minutes",
            "Volunteer for a local charity or organization",
            "Explore a new hiking trail",
            "Learn to juggle three balls",
            "Host a small dinner party or gathering",
            "Try a new type of healthy drink",
            "Write down three things you're grateful for",
            "Build a small piece of furniture or assemble a DIY kit",
            "Watch a classic film you've never seen before",
            "Clean and organize your car",
            "Complete an unfinished project",
            "Make a homemade gift for someone special",
            "Go for a bike ride in your neighborhood",
            "Try a new craft or art project",
            "Have a technology-free day",
            "Create a vision board for your future goals",
            "Write a note for your future self",
            "Learn a few basic phrases in a new language",
        };
        Random random = new Random();
        int index = random.Next(prompts.Length);
        return prompts[index];
    }

}