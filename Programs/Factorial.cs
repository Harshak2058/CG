using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programs
{
    public class Factorial
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());
        long factorial = 1;

        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }

        Console.WriteLine($"Factorial of {number} is {factorial}");
    }
}