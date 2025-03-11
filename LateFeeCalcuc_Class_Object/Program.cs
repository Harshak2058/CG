using System;
namespace LateFeeCalcuc_Class_Object
{
    public class Program 
    {
        public static void Main()
        {
            Console.WriteLine("Enter the title");
            string Title=Console.ReadLine();
            Console.WriteLine("Enter the author");
            string Author=Console.ReadLine();
            Console.WriteLine("Enter the numPages");
            int NumPages= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the due date");
            DateTime DueDate= Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter the return date");
            DateTime ReturnDate= Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter the days to read");
            int DaysToRead= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the daily late feeRate");
            int LateFeeRate=int.Parse(Console.ReadLine());

            Book b= new Book(Title, Author,NumPages,DueDate,ReturnDate);
            
            double Average= b.AveragePagesReadPerDay(DaysToRead);
            Console.WriteLine("Avereage is: "+ Average);
            double FinalLateFees= b.CalculateLateFee(LateFeeRate);
            Console.WriteLine("Late fees: "+ FinalLateFees);
        }
    }
}
