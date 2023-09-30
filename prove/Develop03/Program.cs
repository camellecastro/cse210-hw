using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        //Please see ScriptureLibrary class. Added this to show creativity and exceed project requirements
        ScriptureLibrary scriptureLibrary = new ScriptureLibrary(); 
        //get random scripture reference 
        Scripture scripture = scriptureLibrary.GetRandomScripture();

        // Main loop
        while (true)
        {        
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            string userInput = Console.ReadLine().ToLower();

            if (userInput == "quit")
            {
                Console.WriteLine("\nThank you for using the Scripture Memorizer.\n");
                Environment.Exit(0);
            }
            else if (userInput == "" && !scripture.IsCompletelyHidden())
            {
                //made sure that hidden words are randomly select from only those words that are not already hidden (see Scripture class for reference)
                scripture.HideRandomWords(1);
            }
            else if (userInput == "" && scripture.IsCompletelyHidden())
            {
                Console.WriteLine("\nCongratulations! You just memorized a doctrinal mastery.\n");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("\nInvalid input. Press Enter to continue...");
                Console.ReadLine();
            }
        }
    }
}