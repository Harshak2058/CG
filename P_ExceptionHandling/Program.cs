using System;

public class CustomException : Exception
{
    public CustomException(string message) : base(message) { }
}

class Program
{
    static void ValidateAge(int age)//20//15
    {
        if (age < 0)
            throw new CustomException("Age cannot be negative.");
        if (age < 18)
            throw new CustomException("Age must be at least 18.");
    }

    static void Main()
    {
        try
        {
            Console.Write("Enter age: ");
            int age = Convert.ToInt32(Console.ReadLine());//20//15
            ValidateAge(age);//20//15
            Console.WriteLine("Age is valid.");
        }
        catch (CustomException ex)
        {
            Console.WriteLine($"Custom Exception Caught: {ex.Message}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter a valid number.");
        }
        finally
        {
            Console.WriteLine("Execution completed.");
        }
    }
}

           