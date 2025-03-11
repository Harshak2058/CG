using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Program
    {
        public static void Main(string[] args)
    {
        Shapes shape = new Shapes();
        Console.WriteLine("1. Calculate area of rectangle");
        Console.WriteLine("2. Calculate area of square");
        Console.WriteLine("3. Calculate area of triangle");
        Console.WriteLine("Enter your choice:");
        
        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice == 1)
        {
            Console.WriteLine("Enter the length:");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the breadth:");
            int breadth = Convert.ToInt32(Console.ReadLine());
            int area = shape.CalculateArea(length, breadth);
            Console.WriteLine(area);
        }
        else if (choice == 2)
        {
            Console.WriteLine("Enter the length:");
            double length = Convert.ToDouble(Console.ReadLine());
            double area = shape.CalculateArea(length);
            Console.WriteLine(area);
        }
        else if (choice == 3)
        {
            Console.WriteLine("Enter the breadth:");
            float breadth = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter the height:");
            float height = Convert.ToSingle(Console.ReadLine());
            float area = shape.CalculateArea(breadth, height);
            Console.WriteLine("area is : "area);
            
        }
    }

    }
}