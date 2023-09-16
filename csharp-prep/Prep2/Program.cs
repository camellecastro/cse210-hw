using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Hello, what is your grade percentage? ");
        string gradePercentage = Console.ReadLine ();
        int percentage = int.Parse(gradePercentage);

        string letter = "";

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";    
        }
        else if (percentage >= 60)
        {
            letter = "D";   
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine ("");

        //stretch challenge
        if (percentage >= 60 && percentage < 90 && (percentage % 10) < 3)
        {
            letter += "-";
            Console.WriteLine ($"Your letter grade is: {letter}");
        }
        else if (percentage >= 60 && percentage < 90 && (percentage % 10) >= 7)
        {
            letter += "+";
            Console.WriteLine ($"Your letter grade is: {letter}");
        }
        else if (percentage >= 90 && (percentage % 10) < 3)
        {
            letter += "-";
            Console.WriteLine ($"Your letter grade is: {letter}");
        }
        else
        {
            Console.WriteLine ($"Your letter grade is: {letter}");
        }

        //Console.WriteLine ("");
        //Console.WriteLine ($"Your letter grade is: {letter}");

        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed.");
        }
        else 
        {
            Console.WriteLine("Sorry, you did't pass. Never give up. Better luck next time.");
        }
    }
}