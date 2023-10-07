using System;
using System.Collections.Generic;

// Subclass for Listing Activity
public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _count = 0;
    
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");

    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("List as many responses you can to the following prompt:");
        GetRandomPrompt();
        ShowCountDown(9);
        Console.WriteLine(" ");
        _count = GetListFromUser().Count;
        Console.WriteLine($"You listed {_count} items.");
        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        // Generate a random index to select a random prompt from the list
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string prompt = _prompts[index];

        Console.WriteLine($"\n--- {prompt} ---\n");
        Console.Write("You may begin in: ");
    }

    public List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            items.Add(item);
        }
        return items;
    }
}
