//LINQ = Language Integrated Querys
// powerful feature to query collection
using System;
using System.Collections.Generic;
using System.Linq;
using LivingThings;
class LINQ
{
    void Test()
    {
        byte[] numbers = {23, 45, 11,22, 33, 12, 90, 98, 87, 65, 55};

        //filtering
        //Get all even numbers
        var evenNumbersWithLinq = numbers.Where(numbers => numbers % 2 == 0); // Declarative method vs imperitative method
        //Lamda expression as parameter to Where operator

        var oddNumbersWithLinq = numbers.Where(odd => odd % 2 != 0);



        var lessThanFiftyWithLinq = numbers.Where(numbers => numbers < 50);

        foreach (var number in lessThanFiftyWithLinq)
        {
            Console.Write("Numbers less than fifty are "+ );
        }

        var oddNumbersLessThanFifty = numbers.Where(x => x < 50 && x % 2 == 1);
        PrintOutput(oddNumbersLessThanFifty, "oddNumbersLessThan50");


        string[] names = {"Arun","Barun","Chet","Anil","Bishnu"};
        //Get all names which starts with letter B
        
        var nameStartingB = names.Where(x => x.StartsWith("B"));
        PrintOutput(nameStartingB, "namesStartingB");

        //Projections
        //Get Squares of each element in "numbers" array
        var squares = numbers.Select(x => x * x );
        PrintOutput(squares, "squares");
        //alternatively 
        //foreach (var n in squares)
        // {
        //     Console.WriteLine("The square of each number in numbers is : "+n);
        // }

        // Sqaures of numbers > 70

        // Method syntax
        var squaresGreater70 = numbers.Where(x => x > 70).Select(z => z * z);

        // Expression syntax
        squaresGreater70 = from x in numbers
                           where x > 70
                           select x * x;

        //Square root of all numbers which are multiple of 3

        // MS
        var srofnm3 = numbers.Where(x => x % 3 == 0).Select(y => Math.Sqrt(y));

        //ES
        srofnm3 = from x in numbers
                  where x % 3 == 0
                  select Math.Sqrt(x);

        // Check if ANY of the number is multiple of 7 on "numbers"
        var multipleOf7 = numbers.Any(x => x % 7 == 0);

        // Check if ALL the numbers in "numbers" are multiple of 7
        var allMultipleOf7 = numbers.All(x => x % 7 == 0);

        // Get first 5 items in numbers
        var first5 = numbers.Take(5);

        // Skip first 2 and get next 5
        var skip2AndGetNext5 = numbers.Skip(2).Take(5);

        Person p1 = new Person();
        p1.age = 23;

        Person p2 = new Person();
        p2.age = 32;

        Person p3 = new Person();
        p3.age = 33;

        Person p4 = new Person();
        p4.age = 20;

        Person p5 = new Person();
        p5.age = 26;

        Person p6 = new Person();
        p6.age = 12;

        Person[] people = { p1, p2, p3, p4, p5, p6 };

        // Get all people who are adult now
        var adults = people.Where(x => x.age > 18);
    }

    void PrintOutput<T>(IEnumerable<T> items, string displayText)
    {
        Console.WriteLine($"Printing {displayText}");
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }

    Animal wolf = new Animal();
    wolf.domestic = false;
    wolf.numberOfLegs = 4;
    Animal dog = new Animal();
    dog.domestic = true;
    dog.numberOfLegs = 4;

    Animal cat = new Animal();
    cat.domestic = true;
    cat.numberOfLegs = 4;
    Animal ant = new Animal();
    ant.domestic = false;
    ant.numberOfLegs = 8;

    Animal whale = new Animal();
    whale.domestic = false;
    whale.numberOfLegs = 0;

    Animal [] listOfAnimals = {"wolf","dog","cat","ant","whale"};
        
    }
}
// Create list/array of animals using Animal class we wrote.
// Query that collection to find following:
// Get list of all domestic animals
// Get list of animals which has more than 4 legs
}
