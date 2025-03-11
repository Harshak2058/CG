using System;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        // Prompt the user to enter a colon-separated string
        Console.WriteLine("Enter the string");
        string input = Console.ReadLine();

        // Split the input string into words using the colon as a delimiter
        string[] words = input.Split(':');

        // Check the number of words
        if (words.Length > 15)
        {
            Console.WriteLine("Invalid length");
        }
        else
        {
            // Group words (case-insensitive) and count occurrences
            var wordCounts = words
                .Select(word => word.ToUpper())
                .GroupBy(word => word)
                .ToDictionary(group => group.Key, group => group.Count());

            // Display the word counts
            foreach (var pair in wordCounts)
            {
                Console.WriteLine($"{pair.Key}:{pair.Value}");
            }
        }
    }
}
