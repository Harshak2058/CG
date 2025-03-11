using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        LinkedList<int> numbers = new LinkedList<int>();
        numbers.AddLast(10);
        numbers.AddLast(20);
        numbers.AddLast(30);
        numbers.AddFirst(5);  

        Console.WriteLine("LinkedList elements:");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
        numbers.Remove(20);

        if (numbers.Contains(30))
        {
            Console.WriteLine("\n30 exists in the LinkedList.");
        }
    }
}

