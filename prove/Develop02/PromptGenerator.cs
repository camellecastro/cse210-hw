using System;
using System.Collections.Generic;
public class PromptGenerator 
//responsibility: Supplies random prompts whenever needed.
{    
    //_prompts : List<string>
    public List<string> _prompts = new List<string>(); 

    public PromptGenerator() //constructor
    {
        // Initialize the list of prompts in the constructor
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
        _prompts.Add("What am I grateful for today?");
        _prompts.Add("What was the highlight of my day?");
        _prompts.Add("What challenges or obstacles did I face today, and how did I handle them?");
        _prompts.Add("How did I feel when I woke up this morning, and how do I feel now?");
        _prompts.Add("What are my goals for today, and did I accomplish them?");
        _prompts.Add("What is something I learned today?");
        _prompts.Add("What made me smile or laugh today?");
        _prompts.Add("Write about a moment of kindness I witnessed or experienced today.");
        _prompts.Add("What is one thing I could have done better today, and how can I improve it in the future?");
        _prompts.Add("Describe a person I interacted with today and how they impacted my day.");
        _prompts.Add("Write down a quote or phrase that resonated with me today and explain why.");
        _prompts.Add("Reflect on my current state of mind and any emotions that stand out.");
        _prompts.Add("What are my priorities for tomorrow?");
        _prompts.Add("Write about a recent dream or something that's been on my mind lately.");
        _prompts.Add("How did I take care of my physical and mental health today?");
        _prompts.Add("What are some things that brought me peace or made me feel calm today?");
        _prompts.Add("Describe a moment of personal growth or self-discovery today.");
        _prompts.Add("Write about a decision I made today and its outcome.");
        _prompts.Add("What is a goal or aspiration I have for the long-term, and what steps can I take to work towards it?");
        _prompts.Add("Write a letter to my future self, reflecting on today and offering advice or encouragement.");
    }

    //GetRandomPrompt() : string
    public string GetRandomPrompt()
    {
        // Generate a random index to select a random prompt from the list
        Random random = new Random();
        int index = random.Next(0, _prompts.Count);

        // Return the random prompt
        return _prompts[index];
    }

}