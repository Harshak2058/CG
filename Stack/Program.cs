using System;
using System.Collections.Generic;
namespace Stack
{
    public class Program{
        public static void Main(string[] args) {
     
        Stack<int> numbers = new Stack<int>();

       
        numbers.Push(10);
        numbers.Push(20);
        numbers.Push(30);
        numbers.Pop();
        int top = numbers.Peek(); 
        Console.WriteLine(top);

        // traversing
        Console.WriteLine("Stack Elements:");
        foreach (int num in numbers) {
            Console.WriteLine(num);
        }
    }
    }
}
