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
            Console.WriteLine($"\nYou have {_score} points.\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

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
                else if (userChoice == "6")
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
            selectedGoal.RecordEvent();
            _score += selectedGoal.RecordEvent();
            Console.WriteLine($"Congratulations! You've earned {selectedGoal.RecordEvent()} points.");
            Console.WriteLine("Event recorded!");
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
        }
        Console.WriteLine($"\nGoals successfully loaded from '{filename}'.\n");
    }

}