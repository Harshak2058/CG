using System;
using System.Collections.Generic;
namespace ObjectInitializer_CollectionInitializer
{
class Program
{
    public static void Main(string[] args)
    {
        Person person = new Person("Harsha", 50);
        MyClass obj = new MyClass(new List<string> { "Apple", "Banana", "Cherry" });

        Console.WriteLine("Person Details:");
        Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");

        Console.WriteLine("\nList of Items:");
        foreach (var item in obj.Items)
        {
            Console.WriteLine(item);
        }
    }
}
}

