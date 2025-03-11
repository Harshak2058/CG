using System;
namespace mockSeaInhabitant
{
    public class Program 
    {
        public static void Main()
        {
            Console.WriteLine("Enter the name of the Species");
            string species= Console.ReadLine();
            Console.WriteLine("Enter the price of the fish");
            double price= Convert.ToDouble(Console.ReadLine());
            
           FishUtility utility =new FishUtility();
            utility.AddFish(species,price);

            bool check=utility.BuyFish();
            if(check)
            {
                 Console.WriteLine("Enter the number of the fishes you need to buy");
            int numberOfFish= int.Parse(Console.ReadLine()); 
                 double Total_Cost=utility.CalculatePrice(numberOfFish);
           Console.WriteLine("Total cost is"+ Total_Cost);

            }
            else
           {
                Console.WriteLine($"{utility.Species} species not found");
           }
           
        }
    }
}
