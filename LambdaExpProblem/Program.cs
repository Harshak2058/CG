using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        //even numbers in list
        // List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        // var evenNums = numbers.Where(n => n % 2 == 0).ToList();
        // Console.WriteLine("even numbers are:");
        // foreach (var num in evenNums)
        // {
        //     Console.WriteLine(num);
        // }

        //sum of two numbers
        Func<int, int, int> add = (a, b) => a + b;

        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int result = add(num1, num2); 
        Console.WriteLine($"Sum: {result}");


        Func<int> ConstValue = () => 1;
        int output = ConstValue();
        Console.WriteLine(output);

         List<string> list1 = new List<string> { "apple", "banana", "cherry", "date" };
        
        var lengths = list1.Select(s => s.Length).ToList();

        foreach (var length in lengths)
        {
            Console.WriteLine("length of string");
            Console.WriteLine(length);
        }
        List<int> numbers = new List<int> { 10, 20, 30, 40, 50, 50 };
        var secondLargest = numbers.Distinct() .OrderByDescending(n => n).Skip(1).FirstOrDefault();
        Console.WriteLine("Second largest unique element: " + secondLargest);

        List<string> names = new List<string> { "alice", "bob", "charlie" };

var upperCaseNames = names.Select(name => name.ToUpper()).ToList();

foreach (var name in upperCaseNames)
{
    Console.WriteLine(name);
}


    }
}

