using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine ("Enter a list of numbers, type 0 when finished.");

        List <int> numbers = new List<int>();
        
        int numberEntry = -1;

        while (numberEntry != 0)
        {
            Console.Write("Enter number: ");
            
            string userEntry = Console.ReadLine();
            numberEntry = int.Parse(userEntry);
            
            // Only add the number to the list if it is not 0
            if (numberEntry != 0)
            {
                numbers.Add(numberEntry);
            }
        }

        // Part 1 - Sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        // Part 2 - Average
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Part 3 - Max or Largest Number and stretch challenge minimum
        int max = numbers[0];
        int minPositive = 0;
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
            else if (number > 0 && minPositive == 0)
            {
                minPositive = number;
            }
            else if (number > 0 && number < minPositive)
            {
                minPositive = number;
            }
        }

        Console.WriteLine($"The largest number is: {max}");

        if (minPositive == 0)
        {
            Console.WriteLine("There's no positive numbers entered.");
        }
        else
        {
            Console.WriteLine ($"The smallest positive number is: {minPositive}");
        }

        //stretch challenge

        //Sort
        Console.WriteLine ("The sorted list is: ");
        numbers.Sort();

        foreach (int number in numbers)
        {
            Console.WriteLine (number);
        }
    }
    
}