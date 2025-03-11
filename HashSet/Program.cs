using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<int> numbers = new HashSet<int> { 10, 20, 30, 40 };

        numbers.Add(50);
        numbers.Add(20); // Won't be added because 20 already exists

        numbers.Remove(30);

        if (numbers.Contains(40))
        {
            Console.WriteLine("40 exists in the HashSet.");
        }

        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
    }
}

