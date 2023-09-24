using System;
using System.Collections.Generic;
using System.IO;
class Program
{
    static void Main(string[] args)
    {   
        Journal theJournal = new Journal();

        while (true)
        { 
            Console.WriteLine(""); //white space
            Console.WriteLine("My Daily Journal"); //program title
            Console.WriteLine (""); //whitespace

            //Menu
            Console.WriteLine ("1. Write A New Entry");
            Console.WriteLine ("2. Display My Journal");
            Console.WriteLine ("3. Save Journal Entry To A File");
            Console.WriteLine ("4. Load Journal Entries From A File");
            Console.WriteLine ("5. Exit");
            Console.WriteLine (""); //white space

            Console.Write ("What do I like to do? ");
            string userChoice = Console.ReadLine(); 
            Console.WriteLine(""); //white space

            bool choice = false; //set this for line 73 save entry "n" option to go back at menu | resource: "https://stackoverflow.com/questions/6719630/how-to-escape-a-while-loop-in-c-sharp"
            while (!choice) 
            {
                if (userChoice == "1")
                {
                    Entry anEntry = new Entry();
                    PromptGenerator genPrompt = new PromptGenerator();

                    //set current date
                    //DateTime theCurrentTime = DateTime.Now;
                    anEntry._date = DateTime.Now.ToShortDateString();
        
                    //generateprompt
                    anEntry._promptText = genPrompt.GetRandomPrompt();
                    Console.WriteLine(anEntry._promptText);
                    anEntry._entryText= Console.ReadLine();
                    Console.WriteLine(""); //white space
                    Console.Write("Entry Title: "); //additional information Title for creativity
                    anEntry._title = Console.ReadLine();
                    Console.Write("Current location: "); //additional information Location Entry for creativity
                    anEntry._location = Console.ReadLine();
                    Console.WriteLine(""); //white space
                    // theJournal.AddEntry(anEntry); 

                    //ANOTHER FEATURE: saving option on every entry instead of automatically adding entries on the list for creativity
                    bool exit = false;
                    while (!exit)
                    {
                        Console.Write("Save entry (y/n)? ");
                        string saveChanges = Console.ReadLine();
                        Console.WriteLine(""); //white space

                        if (saveChanges == "y")
                        {
                            theJournal.AddEntry(anEntry);
                            Console.WriteLine("Entry saved!"); //Console.WriteLine("Save to (filename): ");
                            Console.WriteLine(""); //white space
                            Console.WriteLine("DON'T FORGET to save journal entry to a file before closing the program.");

                            //!uncomment line 63, 68 & 69 if you want user to directly save journal entry to a file!!!! for creativity
                            //string saveFileName = Console.ReadLine();
                            //theJournal.SaveToFile(saveFileName);
                            choice = true; //go back to menu options
                            break;
                        }
                        else if (saveChanges == "n")
                        {
                            Console.WriteLine ("Entry's not been saved.");
                            Console.WriteLine(""); //white space
                            exit = true; //exit current loop
                            choice = true; //go back to menu options
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid choice. Please try again.");
                            Console.WriteLine(""); //white space
                        }
                    } 
                }
                else if (userChoice == "2") //displayjournalentry
                {
                    theJournal.DisplayAll();
                    break;
                }   
                else if (userChoice == "3") //savetofile
                {
                    Console.Write("Save to (filename): ");
                    string saveFileName = Console.ReadLine();
                    theJournal.SaveToFile(saveFileName);
                    break;
                }
                else if (userChoice == "4") //loadfromfile
                {
                    Console.Write("Load File (filename): ");
                    string loadFileName = Console.ReadLine();
                    theJournal.LoadFromFile(loadFileName);
                    break;
                }
                else if (userChoice == "5") //exit
                {
                    Environment.Exit(0);
                    break;
                }
                else //Continues loop until choice = true or userChoice = 5
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
                }
            }
        }
    }
}