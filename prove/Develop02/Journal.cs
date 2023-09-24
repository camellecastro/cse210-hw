
using System;
using System.Collections.Generic;
using System.IO;
public class Journal //responsibility: Stores a list of journal entries
{
    //Attribute: _entries : List<Entry> (this is member variable)
    public List<Entry> _entries = new List<Entry>();

    //Methods:
    //AddEntry(newEntry : Entry) : void 

    public void AddEntry(Entry newEntry)
    {
        Entry entry = new Entry();
        _entries.Add(newEntry);
    }

    //DisplayAll() : void
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    //SaveToFile(file : string):void
    public void SaveToFile(string filename)
    {
        Console.WriteLine(""); //white space
        Console.WriteLine("Saving changes . . .");
        Console.WriteLine(""); //white space

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                //title,date,location,prompttext,entrytext
                outputFile.WriteLine($"{entry._title}|{entry._date}|{entry._location}|{entry._promptText}|{entry._entryText}");
            }
        }
        
        Console.WriteLine(""); //white space
        Console.WriteLine("Changes saved!");
        Console.WriteLine(""); //white space
    }
    
    //LoadFromFile(file : string):void
    public void LoadFromFile(string filename)
    {
        Console.WriteLine(""); //white space
        Console.WriteLine("Loading files . . .");
        Console.WriteLine(""); //white space
        //_entries.Clear();

        //string array *simple and straightforward way
        string [] lines = System.IO.File.ReadAllLines(filename);        
        foreach (string line in lines)
        {
            //line strippings
            string[] parts = line.Split("|");
            if (parts.Length == 5)
            {
                Entry oldEntry = new Entry();
                oldEntry._title = parts[0];
                oldEntry._date = parts[1];
                oldEntry._location = parts[2];
                oldEntry._promptText = parts[3];
                oldEntry._entryText = parts[4];
                _entries.Add(oldEntry);

                //title,date,location,prompttext,entrytext
                //parts [0] - Title
                //parts [1] - Date
                //parts [2] - Location
                //parts [3] - Prompt
                //parts [4] - Entry
            }  
        }

        Console.WriteLine($"Choose Menu Option 2 to Display Journal Entries stored in {filename}");
        Console.WriteLine(""); //white space
            
    }
}
