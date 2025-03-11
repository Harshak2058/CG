using System;
namespace DoggoDealingRepractise
{
    public class Program 
    {
        public static void Main()
        {
            Console.WriteLine("Enter the dog breed to buy:");
            string breed = Console.ReadLine();
            Console.WriteLine("Enter the price per dog");
            int pricePerDog = Convert.ToInt32(Console.ReadLine());
            DogUtility utility= new DogUtility();
            utility.AddDog(breed, pricePerDog);

            bool check=utility.BuyDog();
            {
                if(check)
                {
                    Console.WriteLine("Enter the number of dogs you need to buy");
                    int numberOfDogs= Convert.ToInt32(Console.ReadLine());
                    double final_price=utility.CalculatePrice(numberOfDogs);
                    Console.WriteLine($"Total cost is "+final_price);
                }
                else{
                    Console.WriteLine($"{utility.Breed} breed is not found");
                }
            }
            
        }
    }
}
