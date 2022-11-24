
using System;
class Methods
{
    public void Print()
    {
        Console.WriteLine("I am a simple method");

    }
    //return nothing, takes some arguments

    public void PrintSomething(string message)
    {
        Console.WriteLine(message);
    }
    //return sth, takes some arguments
    //num3 is optional
    public double Add(double num1, double num2, double num3=0)
    {
        var sum = num1+num2+num3;
        return sum;
    }

    // return sth, takes arbitary number of arguments
    public long Multiply(params int[] numbers)
    {
        long product = 1;
        foreach(var num in numbers)
        {
            product *= num;
        }
        return product;
    }

    //returns multiple values, take some arguments
    public (byte, byte) GetMinMax(byte[] nums)
    {
        byte min = byte.MaxValue, max = byte.MinValue;
        foreach(byte n in nums) 
        {
            if(n < min)
            {
                min = n;
            }
            if(n > max)
            {
                max = n;
            }
        }
        return(min, max);
    }


    //CW: write a method which returns average of all 4 numbers supplied as parameter

    public float calAverage(short n1, short n2, short n3, short n4)
    {
        float average = (n1+n2+n3+n4) / 4.0f;  //4.0f = casting from short to float
        return average;
    }
    //modify this method to take array of numbers and cal avg of all.
    public float calAverageArray(float[] numbers)
    {
        float sum = 0;
        float average;
        foreach(var n in numbers)
        {
            sum = sum + n;
        }
        average = sum/numbers.Length;
        return average;
    }
    // modify method to return average and min of all numbers. 
    public float calAverageAndMinArray(float[] numbers) // 11 22 22 33 
    {
        float sum = 0;
        float average;
        float min = float.MinValue;
        foreach(var n in numbers)
        {
            sum = sum + n;
        }
        foreach(var n in numbers)
        {
            if(n<min)
            {
                min = n;
            }
        }
        average = sum/numbers.Length;
        return average;
    }
}