using System;
using System.Security.Cryptography.X509Certificates;

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
            Console.WriteLine("\nEternal Quest - Goals and Score\n");
            DisplayPlayerInfo();
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit\n");
            Console.Write($"Select a choice from the menu: ");

            string userChoice = Console.ReadLine();

            while (true)
            {
                if (userChoice == "1")
                {
                    Console.Clear();
                    Console.WriteLine("The types of Goals are: \n");
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Eternal Goal");
                    Console.WriteLine("3. Checklist Goal\n");
                    Console.Write("Which type of goal would you like to create? ");
                    string goalType = Console.ReadLine();

                    if (goalType == "1")
                    {
                        SimpleGoal newSimpleGoal = new SimpleGoal();
                        CreateGoal();
                        _goals.Add(newSimpleGoal);
                        break;
                    }
                    else if (goalType == "2")
                    {
                        EternalGoal newEternalGoal = new EternalGoal();
                        CreateGoal();
                        _goals.Add(newEternalGoal);
                        break;
                    }  
                    else if (goalType == "3")
                    {
                        ChecklistGoal newChecklistGoal = new ChecklistGoal();
                        CreateGoal();
                        _goals.Add(newChecklistGoal);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid goal type. Please try again.");
                        
                    }
                    break;
                }
                else if (userChoice == "2")
                {
                    ListGoalNames();
                    ListGoalDetails();
                    break;
                }
                else if (userChoice == "3")
                {
                    SaveGoals();
                    break;
                }
                else if (userChoice == "4")
                {
                    LoadGoals();
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
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
                }     
            }
        }

    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points.\n");
    }
    public void ListGoalNames()
    {

    }
    public void ListGoalDetails()
    {

    }
    public void CreateGoal()
    {

    }
    public void RecordEvent()
    {

    }
    public void SaveGoals()
    {
       
    }
    public void LoadGoals()
    {

    }
}

