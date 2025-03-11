using System;
using System.Collections.Generic;
namespace Hashable
{
    public class Program{

 public static void Main() 
   {
        Hashtable students = new Hashtable(); 

        students.Add(1, "Alice");
        students.Add(2, "Bob");
        students.Add(3, "Charlie");

        foreach (DictionaryEntry entry in students) {
            Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
        }
    }
}
}