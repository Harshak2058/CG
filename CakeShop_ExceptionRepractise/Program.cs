using System;
namespace CakeShop_ExceptionRepractise
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter the flavour");
            string flavour= Console.ReadLine();
            Console.WriteLine("Enter the quantity in kg");
            int quantity= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the price per kg");
            double pricePerKg= Convert.ToDouble(Console.ReadLine());
            Cake cake=new Cake
            {
                Flavour = flavour, QuantityInKg= quantity, PricePerKg=pricePerKg
            };
            
            try
            {
                bool check =cake.CakeOrder();
                if(check)
                {
                    double final_Discount=cake.CalculatePrice();
                    Console.WriteLine("Price after discount is "+final_Discount);
                }
                // else
                // {
                //     Console.WriteLine("Flavour not available. Please select the available flavour ");
                // }

            }
            catch(InvalidFlavourException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
