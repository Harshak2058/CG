using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Creating a dictionary
        Dictionary<int, string> students = new Dictionary<int, string>
        {
            { 102, "Harsha" },
            { 101, "Avi" },
            { 104, "Ronnie" }
        };

        // Sorting by Key Asc Order
         var sortedByValue = students.OrderBy(kv => kv.Value).ToDictionary(kv => kv.Key, kv => kv.Value);

        Console.WriteLine("Sorted by Key:");
        foreach (var item in sortedByValue)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }
}

