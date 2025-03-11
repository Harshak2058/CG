using System;
namespace TotalPrice_PolymorphismRepractise
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("1. Price Without Discount");
            Console.WriteLine("2. Price With Discount");
            Console.WriteLine("Enter the choice");
            string choice= Console.ReadLine();
            Console.WriteLine("Enter the price");
                decimal price= Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Enter the quantity");
                int quantity= Convert.ToInt32(Console.ReadLine());
            Product p = new Product();
           if(choice=="1")
           {
            decimal NoDiscountPrice=p.CalculateTotalPrice(price, quantity);
           Console.WriteLine("Total price Without Discount "+ NoDiscountPrice);
           }
           else if(choice =="2")
           {
            Console.WriteLine("Enter the discount Percentage");
            int discountPercentage= Convert.ToInt32(Console.ReadLine());
           decimal FinalDiscountPercentage= p.CalculateTotalPrice(price,quantity,discountPercentage);
            Console.WriteLine("Total price With Discount "+FinalDiscountPercentage);
           }    
        }
    }
}
