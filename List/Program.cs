using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 10, 20, 30, 40 };

        numbers.Add(50);
        numbers.AddRange(new int[] { 60, 70 });

        numbers.Remove(30); // Removes first occurrence of 30
        numbers.RemoveAt(0); // Removes element at index 0
        if (numbers.Contains(40))
        {
            Console.WriteLine("40 is in the list.");
        }
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
        List<string> Names= new List<string>();
        Names.Add("Har sha");
        Names.Add("Shasha");
        foreach (string str in Names)
        Console.WriteLine(str);
    }
}

