using System;

//Guess My Number Game

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine ("Guess My Number Game");
        Console.WriteLine ("");

        //Part 1 and 2, where the user chooses the magic number
        //Console.Write ("What is the magic number? ");
        //int magicNumber = int.Parse(Console.ReadLine());

        //Part 3, random number generator from 1-100
        Random randomGenerator = new Random ();
        int magicNumber = randomGenerator.Next(1,101);

        int guess = -1;
        int count = 0;

        //for blank line
        Console.WriteLine ("");

        //do or while loop
        while (guess != magicNumber)
        {
            Console.Write ("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            count += 1;

            if (magicNumber > guess)
            {
                Console.WriteLine ("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                //for blank line
                Console.WriteLine ("");

                Console.WriteLine ("You're a genius! You guessed it!");
                Console.WriteLine ($"It took you {count} guesses.");

            }
        }
        
    }
}