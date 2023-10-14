// using System;

// public class GoalManager
// {
//     private List<Goal> _goals;
//     private int _score;

//     public GoalManager()
//     {
//         _goals = new List<Goal>();
//         _score = 0;
//     }
//     public void Start()
//     {
//         while (true)
//         {
//             Console.WriteLine("\nEternal Quest - Goals and Score\n");
//             DisplayPlayerInfo();
//             Console.WriteLine("1. Create New Goal");
//             Console.WriteLine("2. List Goals");
//             Console.WriteLine("3. Save Goals");
//             Console.WriteLine("4. Load Goals");
//             Console.WriteLine("5. Record Event");
//             Console.WriteLine("6. Quit\n");
//             Console.Write($"Select a choice from the menu: ");

//             string userChoice = Console.ReadLine();

//             while (true)
//             {
//                 if (userChoice == "1")
//                 {
//                     Console.Clear();
//                     Console.WriteLine("The types of Goals are: \n");
//                     Console.WriteLine("1. Simple Goal");
//                     Console.WriteLine("2. Eternal Goal");
//                     Console.WriteLine("3. Checklist Goal\n");
//                     Console.Write("Which type of goal would you like to create? ");
//                     string goalType = Console.ReadLine();

//                     if (goalType == "1")
//                     {
//                         SimpleGoal newSimpleGoal = new SimpleGoal();
//                         CreateGoal();
//                         _goals.Add(newSimpleGoal);
//                         break;
//                     }
//                     else if (goalType == "2")
//                     {
//                         EternalGoal newEternalGoal = new EternalGoal();
//                         CreateGoal();
//                         _goals.Add(newEternalGoal);
//                         break;
//                     }  
//                     else if (goalType == "3")
//                     {
//                         ChecklistGoal newChecklistGoal = new ChecklistGoal();
//                         CreateGoal();
//                         _goals.Add(newChecklistGoal);
//                         break;
//                     }
//                     else
//                     {
//                         Console.WriteLine("Invalid goal type. Please try again.");
                        
//                     }
//                     break;
//                 }
//                 else if (userChoice == "2")
//                 {
//                     ListGoalNames();
//                     ListGoalDetails();
//                     break;
//                 }
//                 else if (userChoice == "3")
//                 {
//                     SaveGoals();
//                     break;
//                 }
//                 else if (userChoice == "4")
//                 {
//                     LoadGoals();
//                     break;
//                 }
//                 else if (userChoice == "5")
//                 {
//                     RecordEvent();
//                     break;
//                 }
//                 else if (userChoice == "6")
//                 {
//                     Environment.Exit(0);
//                     break;
//                 }
//                 else
//                 {
//                     Console.WriteLine("Invalid choice. Please try again.");
//                     break;
//                 }     
//             }
//         }

//     }
//     public void DisplayPlayerInfo()
//     {
//         Console.WriteLine($"\nYou have {_score} points.\n");
//     }
//     public void ListGoalNames()
//     {

//     }
//     public void ListGoalDetails()
//     {

//     }
//     public void CreateGoal()
//     {

//     }
//     public void RecordEvent()
//     {

//     }
//     public void SaveGoals()
//     {
       
//     }
//     public void LoadGoals()
//     {

//     }
// }

using System;
using System.Collections.Generic;

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
            Console.WriteLine($"You have {_score} points.\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("Select a choice from the menu: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    ListGoalNames();
                    break;
                case 3:
                    SaveGoals();
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:
                    RecordEvent();
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalNames()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void ListGoalDetails()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetStringRepresentation());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Choose a goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        int goalType = int.Parse(Console.ReadLine());

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter goal points: ");
        int points = int.Parse(Console.ReadLine());

        switch (goalType)
        {
            case 1:
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case 2:
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case 3:
                Console.Write("Enter target amount: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid goal type. Goal not created.");
                break;
        }
    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Select a goal to record an event (1 to " + _goals.Count + "): ");
        int goalIndex = int.Parse(Console.ReadLine());

        //adjust the user input to be 0-based
        goalIndex--;

        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            Goal selectedGoal = _goals[goalIndex];
            selectedGoal.RecordEvent();
            _score += selectedGoal.GetPoints();
            Console.WriteLine("Event recorded!");
        }
        else
        {
            Console.WriteLine("Invalid goal selection.");
        }
    }

    public void SaveGoals()
    {
        // Implement code to save goals to a file
        // You can use file I/O to save goals to a text file
    }

    public void LoadGoals()
    {
        // Implement code to load goals from a file
        // You can use file I/O to read goals from a text file
    }
}


