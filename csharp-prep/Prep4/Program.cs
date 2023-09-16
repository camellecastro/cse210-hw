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

        // Part 3 - Max
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
    
}