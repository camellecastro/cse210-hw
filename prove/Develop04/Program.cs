using System;
using System.Threading;
class Program
{
    static void Main(string[] args)
    {
        //for activity log | showing creativity
        //activity log appears upon program exit
        int breathingActivityCount = 0;
        int listingActivityCount = 0;
        int reflectingActivityCount = 0;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program\n");
            Console.WriteLine("Menu:\n");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflecting Activity");
            Console.WriteLine("4. Exit\n");
            Console.Write("Enter your choice from the menu: ");
            string userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
                breathingActivityCount++;
            }
            else if (userChoice == "2")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
                listingActivityCount++;
            }   
            else if (userChoice == "3")                
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
                reflectingActivityCount++;
                //made sure that no random prompts/questions are selected 
                //until they have all been used at least once in that session
            }
             else if (userChoice == "4")
            {
                Console.WriteLine("\nMindfulness Activity Count Log");
                Console.WriteLine($"Breathing Activity Count: {breathingActivityCount}");
                Console.WriteLine($"Listing Activity Count: {listingActivityCount}");
                Console.WriteLine($"Reflecting Activity Count: {reflectingActivityCount}\n");
                Environment.Exit(0);
                break;
            }
            else
            {
                Console.Write("Invalid choice.");
                Thread.Sleep(1000); //pause for 1 second
            }                    
        }
    }
}
