using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace String1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string input = Console.ReadLine();
            string[] words = input.Split(':');
            
            if (words.Length > 15)
            {
                Console.WriteLine("Invalid length");
            }
            else
            {
                string[] uniqueWords = new string[words.Length];
                int[] wordCounts = new int[words.Length];
                int uniqueWordCount = 0;

                for (int i = 0; i < words.Length; i++)
                {
                    string upperWord = words[i].ToUpper();
                    bool found = false;

                    for (int j = 0; j < uniqueWordCount; j++)
                    {
                        if (uniqueWords[j] == upperWord)
                        {
                            wordCounts[j]++;
                            found = true;
                            break;
                        }
                    }

                    if (!found)
                    {
                        uniqueWords[uniqueWordCount] = upperWord;
                        wordCounts[uniqueWordCount] = 1;
                        uniqueWordCount++;
                    }
                }

                for (int i = 0; i < uniqueWordCount; i++)
                {
                    Console.WriteLine($"{uniqueWords[i]}:{wordCounts[i]}");
                }
            }
        }
    }
}
