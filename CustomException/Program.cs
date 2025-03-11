using System;
namespace CustomException
{
class Program
{
    static void Main()
    {
        try
        {
            Person person = new Person("John", 16);
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        }
        catch (AgeException ex)
        {
            Console.WriteLine($"Custom Exception: {ex.Message}");
        }
    }
}
}
