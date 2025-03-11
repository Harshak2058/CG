using System;
namespace SeaInhibitant_ReRePractise
{
    public class Program 
    {
        public static void Main()
        {
            Console.WriteLine("Enter the species to buy");
            string species= Console.ReadLine();
            Console.WriteLine("Enter the price per fish");
            double pricePerFish= Convert.ToDouble(Console.ReadLine());
            

            FishUtility utility= new FishUtility();
            utility.AddFish(species, pricePerFish);

            bool check=utility.BuyFish();
            if(check)
            {
                Console.WriteLine("Enter the number of fishes you need to buy");
                int numberOfFishes= Convert.ToInt32(Console.ReadLine());
                double final_price=utility.CalculatePrice(numberOfFishes);
                Console.WriteLine("The total cost is "+final_price);
            }

            else{
                Console.WriteLine($"{utility.Species} species not found");
            }
        }
    }
}
