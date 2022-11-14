using System;

// Top-level statements - implicit Main() entrypoint
//Conditional - branching

Console.Write("Enter any number: ");
string numberText = Console.ReadLine();
short number = short.Parse(numberText);  

if(number % 2 == 0)
{
    Console.WriteLine(number + " is Even");
}
else
{
    Console.WriteLine(number + " is Odd");
}

//Classwork: Ask user to enter his name and convert that to uppercase and print on console
Console.Write("Enter a name: ");
string name = Console.ReadLine();
string UpperCaseName = name.ToUpper();
Console.Write(name + " Converted to Upper Case is: " + UpperCaseName);


















// Person person1 = new();
// person1.name = "Smith";
// person1.age = 12;

// string message = person1.GetLegalGreeting();
// Console.WriteLine(message);


