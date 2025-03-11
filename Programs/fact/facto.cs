using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace factoo
{
    public class fact
    {
         public static void Main(string[] args)
         {
        Console.Write("Enter any Number: ");
            int number = int.Parse(Console.ReadLine());
            int fact = 1;

            for (int i = 1; i <= number; i++)
            {
                fact *= i;
            }

            Console.WriteLine("Factorial of " + number + " is: " + fact);   
    }
}
}