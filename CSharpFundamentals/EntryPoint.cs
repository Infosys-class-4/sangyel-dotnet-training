using System;

// Top-level statements - implicit Main() entrypoint
// Conditional - branching,
class EntryPoint
{
    public static void Main()
    {
        // Arrays a = new();
        // a.LearnArrays();

        // Assignment a = new();
        // a.question6();

        Methods m =new();
        m.Print();
        m.PrintSomething("I am yet another method");
        var s = m.Add(45.67,67.89,12.4);
        var s1 = m.Add(45.67,67.89);
        Console.WriteLine($"Sum 1 = {s}");
        Console.WriteLine($"sum 2 = {s1}");
        var p1 = m.Multiply(5,6,7,8);
        var p2 = m.Multiply(5,6,7,8,10,45,23,45);
        Console.WriteLine($"Product 1 = {p1}; Product 2 = {p2}");

        byte[] numbers = {34,56,12,33,89,65,21,90};
        var(minimum, maximum) = m.GetMinMax(numbers);

        var a1 = m.calAverage(11,22,33,44);
        Console.WriteLine($"Average of 4 numbers is: {a1}");
        
        float[] num1={11.0f, 22 , 33, 44, 55, 66};
        var a2=m.calAverageArray(num1);
        Console.WriteLine($"the average for an Array is {a2}");
        
        


    }
}