using System;
using System.Collections.Generic;
using LivingThings;

class Collection
{
    public void LearnList()
    {
        //string[] names = { "Bishnu", "Ram", "Tek" };

        List<string> nameList = new List<string>();
        nameList.Add("Bishnu");
        nameList.Add("Ram");

        List<byte> ages = new List<byte>() { 23, 45, 34, 78, 9 };

        List<Person> people = new List<Person>();

        // CW - Define list of 10 even numbers.
        var collection1 = new List<string>() { "bishnu", "334", "false", "34.67" };
        //stack and queue
        Stack<string> plates = new Stack<string>(); // LIFO
        plates.Push("Plate1");
        plates.Push("Plate2");
        plates.Push("Plate3");
        plates.Push("Plate4");

        plates.Pop();

        foreach (var item in plates)
        {
            Console.WriteLine(item);
        }

        Queue<string> plateLine = new Queue<string>(); // FIFO
        plateLine.Enqueue("Plate1");
        plateLine.Enqueue("Plate2");
        plateLine.Enqueue("Plate3");

        plateLine.Dequeue();

        foreach (var item in plateLine)
        {
            Console.WriteLine(item);
        }
    }

    public void LearnDictonary()
    {
        Dictionary<string, string> countryCapitals = new();
        countryCapitals.Add("Nepal", "Kathmandu"); //key has to be unique, value can be repeated
        countryCapitals.Add("India", "Delhi");
        countryCapitals.Add("Canada", "Ottawa");
        countryCapitals.Add("Bhutan", "Thimpu");

        foreach (var item in countryCapitals)
        {
            Console.WriteLine($"{item.Key}->{item.Value}");
        }
    }

    //define a dictionary to hold country and its population
    //  country     population
    //  nepal       39238400
    //  india       123456700
    public void Country()
    {
        Dictionary<string, int> population = new();
        population.Add("Nepal", 39238400);
        population.Add("India", 123456700);
        Console.WriteLine("Country\t\tPopulation");
        Console.WriteLine("...........................");

        foreach (var pop in population)
        {
            Console.WriteLine($"{pop.Key}\t\t{pop.Value}");
        }
    }
}