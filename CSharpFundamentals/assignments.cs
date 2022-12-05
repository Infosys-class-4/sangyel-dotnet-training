using System;
using System.Linq;
using System.Data;

// class Assignment
// {
//     public void question4()
//     {
//         int l = 0;
//         for (int j = 1; j <= 3; j++)
//         {
//             for (int k = 1; k <= 4; k++)
//             {
//                 l = l + 1;
//                 Console.Write(l + " ");
//             }
//             Console.WriteLine(" ");
//         }
//     }

//     public void question6()
//     {
//         int ii, jj;
//         for (ii = 1; ii < 90; ii++)
//         {
//             for (jj = 1; jj <= 10; jj++)
//             {
//                 Console.WriteLine(ii + " * " + jj + " = " + ii * jj);
//             }
//         }
//     }
// }
// We have following array:
byte [] numbers = { 23, 45, 11, 21, 33, 12, 90, 98, 87, 65, 55, 99, 234, 76, 10, 82 };
// Find squares of all numbers which are greater than 70
// Find square root of all numbers which are multiple of 3

var greaterThan70 = numbers.Where(x => Math.Pow(2,x) > 70);

var sqrtDivisible3 = numbers.Where(y => Math.Round(Math.Sqrt(y,2) % 3);
    Console.WriteLine("square of numbers greater than 70 is ");
foreach ( var n in greaterThan70)
{
    Console.Write(" "+n);
}
Console.WriteLine();
Console.WriteLine("square root number divisible by 3 is: ");

foreach( var n in sqrtDivisible3)
{
    Console.Write(" "+n);
}




















