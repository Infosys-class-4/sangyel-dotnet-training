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
Console.WriteLine(name + " Converted to Upper Case is: " + UpperCaseName);

int marks = 45;
if(marks < 40)
{
    Console.WriteLine("failed");
}
else if(marks < 60)
{
    Console.WriteLine("Passed. You are placed in second division");
}
else if(marks < 80)
{
    Console.WriteLine("Passed. You are placed in first division");
}
else
{
    Console.WriteLine("Congratulations you have Passed with Distinction");
}

// Console.Write("Enter a number upto 5: ");
// string romanNumerical = Console.ReadLine();
// short number1 = short.Parse(romanNumerical);
// if(number1 == 1)
// {
//     Console.WriteLine("1 roman numerical format is I");
// }
// else if(number1 == 2)
// {
//     Console.WriteLine("2 roman numerical format is II");
// }
// else if(number1 == 3)
// {
//     Console.WriteLine("3 roman numerical format is III");
// }
// else if(number1 == 4)
// {
//     Console.WriteLine("4 roman numerical format is IV");
// }
// else if(number1 == 5)
// {
//     Console.WriteLine("5 roman numerical format is V");
// }
// else
// {
//     Console.WriteLine("Invalid Input, please enter again");
// }

//switch - branching statement and selection statement

// switch(n)
// {
//     case 1: result = "I";
//     break;
//     case 2: result = "II";
//     break;
//     case 3: result = "III";
//     break;
//     case 4: result = "IV";
//     break;
//     case 5: result = "V";
//     break;
// }
// Console.WriteLine(result);



// Person person1 = new();
// person1.name = "Smith";
// person1.age = 12;

// string message = person1.GetLegalGreeting();
// Console.WriteLine(message);


for(int i = 1; i <=100; i++)
{
    if(i % 2 == 0)
    {
        Console.Write(i+" ");
    }
}
Console.WriteLine(" ");

int l=0;

for(int j = 1; j <= 3; j++)
{
    for(int k = 1; k <= 4; k++)
    {
        l= l+1;
        Console.Write(l+" ");
    }
    Console.WriteLine(" ");
}