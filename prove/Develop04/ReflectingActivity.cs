using System;
using System.Collections.Generic;

// Subclass for Reflecting Activity
//added _usePrompts : List<string> and _usedQuestions : List<string> to exceed minimum requirement
public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    private List<string> _usedPrompts = new List<string>(); // list to make sure no prompts are selected until they have all been used at least once in a session
    private List<string> _usedQuestions = new List<string>(); // list to make sure no questions are selected until they have all been used at least once in a session
    public ReflectingActivity()
    {
        _name = "Reflecting";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        
        //prompts
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        //questions
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");

        // Initialize the used lists to be empty initially.
        _usedPrompts = new List<string>(_prompts.Count);
        _usedQuestions = new List<string>(_questions.Count);
    }

    public void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine(" "); //whitespace
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        int timer = _duration;
        while (DateTime.Now < endTime)
        {
            Console.Write("> " + GetRandomQuestion() + " ");
            ShowSpinner(10);
            timer -= 10; // Subtracting 10 seconds for each reflection
        }
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        if (_usedPrompts.Count == _prompts.Count)
        {
            // if all prompts have been used, reset the used list.
            _usedPrompts.Clear();
        }

        Random random = new Random();
        string prompt;
        do
        {
            int index = random.Next(_prompts.Count);
            prompt = _prompts[index];
        }
        while (_usedPrompts.Contains(prompt));

        _usedPrompts.Add(prompt);
        return prompt;
    }

    public string GetRandomQuestion()
    {
        if (_usedQuestions.Count == _questions.Count)
        {
            // If all questions have been used, reset the used list.
            _usedQuestions.Clear();
        }

        Random random = new Random();
        string question;
        do
        {
            int index = random.Next(_questions.Count);
            question = _questions[index];
        }
        while (_usedQuestions.Contains(question));

        _usedQuestions.Add(question);
        return question;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt:\n");
        string prompt = GetRandomPrompt();
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
    }
}