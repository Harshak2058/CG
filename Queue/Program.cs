using System;
using System.Collections.Generic;
namespace Queue
{
    public class Program
    {
        public static void Main(string[] args) 
        {
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);
        if (queue.Count == 0) 
        {
            Console.WriteLine("Queue is empty.");
        }
        if (queue.Contains(20)) {
            Console.WriteLine("--20 is in the queue.--");
            }
        Console.WriteLine("Queue Elements:");
        foreach (int num in queue) {
            Console.WriteLine(num);
        }
        queue.Dequeue(); 
        foreach (int num in queue) {
            Console.WriteLine("--"+num);
        }
        int front = queue.Peek(); 
        Console.WriteLine(front);
    }
}
}

