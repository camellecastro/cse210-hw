using System;
using System.Collections.Generic;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop04 World!");
        
        // Person p1 = new Person();
        // p1._firstName = "Mary";
        // p1._lastName = "Smith";
        // p1._age = 25;

        // Person p2 = new Person();
        // p2._firstName = "John";
        // p2._lastName = "Watskins";
        // p2._age = 30;

        // List<Person> people = new List<Person>();
        // people.Add(p1);
        // people.Add(p2);

        // //to check
        // foreach (Person p in people)
        // {
        //     Console.WriteLine(p._firstName);
        // }

        // SaveToFile(people);

        List<Person> newPeople = ReadFromFile();
        foreach (Person p in newPeople)
        {
            Console.WriteLine(p._lastName);
        }
    }
    public static void SaveToFile(List<Person> people)
        {
            string filename = "people.txt";

            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                foreach (Person p in people)
                {
                    outputFile.WriteLine($"{p._firstName}^{p._lastName}^{p._age}");
                }
            }
        }

    public static List<Person> ReadFromFile()
    {
        Console.WriteLine("Reading list from file . . .");
        List<Person> people = new List<Person>();
        string filename = "people.txt";

        //string array, simple and straightforward
        string [] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            //Console.WriteLine(line);
            //line will have something like this John^Watskins^30
            
            //line strippings

            string[] parts = line.Split("^");

            //parts [0] - Mary
            //parts [1] - Smith
            //parts [2] - 25

            Person newPerson = new Person();
            newPerson._firstName = parts[0];
            newPerson._lastName = parts[1];
            newPerson._age = int.Parse(parts[2]);

            people.Add(newPerson);
        }

        return people;
    }
}