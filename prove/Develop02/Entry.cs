using System;
public class Entry //responsibility: Represent a single journal entry
{
    //Attributes: _date:string | _prompText:string | _entryText:string
    public string _date;
    public string _promptText;
    public string _entryText;
    //additional informations
    public string _title;
    public string _location;

    //Method: Display():void
    public void Display() 
    {
        //display
        Console.WriteLine(""); //whitespace /
        Console.WriteLine(_title);
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Location: {_location}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"* {_entryText}");
        Console.WriteLine(""); //whitespace
    }
}