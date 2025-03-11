using System;
namespace TinyThreadException

{
    public class Program
    {
        public static void Main()
        {
            DeliveryService ds= new DeliveryService();
            Console.WriteLine("Enter the product name");
            string name= Console.ReadLine();
            Console.WriteLine("Enter the number of stocks");
            int stock= int.Parse(Console.ReadLine());

            Product product = new Product{
                Name=name, Stock= stock
            };
            try
            {
               bool check= ds.PlaceOrder(product);//excpt(false), true
               if(check)
               {
                Console.WriteLine("Order placed Succesffully");
               }
               else{
                Console.WriteLine("Product is out of stock");
               }
            }
            catch (ProductOutOfStockException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Custom exception called");
            }

        }
    }
    
}