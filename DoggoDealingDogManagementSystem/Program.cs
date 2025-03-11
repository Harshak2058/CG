using System;


namespace DoggoDealingDogManagementSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DogUtility obj= new DogUtility();
            Console.WriteLine("Enter the dog breed to buy");
            string breed= Console.ReadLine();
            Console.WriteLine("Enter the price per dog");
            double pricePerDog= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the number of dogs you need to buy:");
            obj.AddDog(breed, pricePerDog);

            if(obj.BuyDog())
            {
                int numberOfDogs= Convert.ToInt32(Console.ReadLine());
                double totalCost=obj.CalculatePrice(numberOfDogs);
                 Console.WriteLine($"Total cost is {totalCost} ");
            }
            else{
                Console.WriteLine($"{breed} breed not found");
            }

        }
    }
}
/*
Sample Input 1:

Enter the dog breed to buy:

Labrador

Enter the price per dog:

800

Enter the number of dogs you need to buy:

3
Sample Output 1:

Total cost is 2600

 

Sample Input 2:

Enter the dog breed to buy:

Bulldog

Enter the price per dog:

2000

 

Sample Output 2:

Bulldog breed not found
*/