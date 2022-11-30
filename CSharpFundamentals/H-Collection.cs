using System;
using System.Collections.Generic;
using LivingThings;

class Collection
{
    void LearnList()
    {
        //string[] names = { "Bishnu", "Ram", "Tek" };

        List<string> nameList = new List<string>();
        nameList.Add("Bishnu");
        nameList.Add("Ram");

        List<byte> ages = new List<byte>() { 23, 45, 34, 78, 9 };

        List<Person> people = new List<Person>();

        // CW - Define list of 10 even numbers.
        var collection1 = new List<string>("bishnu", "334","false","34.67");
        //stack and queue
        Stack<string> plates = new Stack<string>(); // LIFO
        plates.Push("Plate1");
        plates.Push("Plate2");
        plates.Push("Plate3");
        plates.Pop();

        Queue<string> plateLine = new Queue<string>(); // FIFO
        plateLine.Enqueue("Plate1");
        plateLine.Enqueue("Plate2");
        plateLine.Enqueue("Plate3");
        plateLine.Dequeue();
    }
}