using System;

class Arrays
{
    public void LearnArrays()
    {
        //declare a number array with at least 10 items, print squares of each in console.

        short[] ages = { 10, 11, 10, 3, 5, 7, 8, 8, 9, 4, 6 };

        for (int i = 1; i <= ages.Length; i++)
        {
            Console.Write(ages[i] * ages[i] + " ");
        }
        Console.Write("\n using for each:");
        foreach (var ages1 in ages)
        {
            Console.Write(ages1 * ages1 + " ");
        }


        for (int eight = 1; eight <= 10; eight++)
        {
            Console.WriteLine($"8 * {eight} = {8 * eight}");
        }
    }
}