using System;
namespace LatefeeREPractise
{
    public class Program 
    {
        public static void Main()
        {
            Console.WriteLine("Enter the title");
            string Title= Console.ReadLine();
            Console.WriteLine("Enter the author");
            string Author= Console.ReadLine();
            Console.WriteLine("Enter the number of Pages");
            int NumPages= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the due date");
            DateTime DueDate= Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter the returned date");
            DateTime ReturnedDate= Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter the days to read");
            int DaysToRead= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the daily late feeRate");
            int LateFeeRate= int.Parse(Console.ReadLine());

        Book b= new Book(Title, Author, NumPages, DueDate, ReturnedDate);

        double averageValue=b.AveragePagesReadPerDay(DaysToRead);
        Console.WriteLine("Average Pages Read Per Day :"+averageValue);

        double lateFeesValue=b.CalculateLateFee(LateFeeRate);
        Console.WriteLine("Late Fee:"+ lateFeesValue);
        }
    }
}
