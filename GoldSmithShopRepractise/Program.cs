using System;
namespace GoldSmithShopRepractise
{
    public class Program 
    {
        public static void Main()
        {
            InventoryService ins = new InventoryService();
            Console.WriteLine("Enter the gold item name:");
            string name= Console.ReadLine();
            Console.WriteLine("Enter the number of stocks");
            int stock= int.Parse(Console.ReadLine());

            GoldItem gi = new GoldItem{
                Name=name, Stock = stock
            };
            try
           {
            bool check=ins.PlaceOrder(gi);
            if(check)
            {
                Console.WriteLine("Order placed successfully");
            }
            else
            {
                Console.WriteLine("Gold item is out of stock");
            }
           }
           catch(GoldItemOutOfStockException ex)
           {
            Console.WriteLine(ex.Message);
        
           }


        }
    }
    
}