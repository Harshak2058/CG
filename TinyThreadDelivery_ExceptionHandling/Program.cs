using System;
namespace TinyThreadDelivery_ExceptionHandling
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try{
            Console.WriteLine("Enter the product name");
            string name= Console.ReadLine();

            Console.WriteLine("Enter the number of stocks");
            int stock= int.Parse(Console.ReadLine());
            Product p = new Product
            {
                Name=name, Stock= stock
            };
            DeliveryService ds= new DeliveryService();
            bool isReturn= ds.PlaceOrder(p);
            if(isReturn)
            {
                Console.WriteLine("Order added successfully");
            }
        }//try closed
        catch(ProductOutOfStockException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            catch(FormatException)
            {
                Console.WriteLine("Enter valid input");
            }


        }
    }
}
