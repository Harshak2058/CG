using System;
namespace PetShopFishInventoryManagement
{  // class (harsha) -- name,, id
    public class program
    { 
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the species to buy");
            string species= Console.ReadLine();

            Console.WriteLine("Enter the Price per fish");
            double pricePerFish=Convert.ToDouble(Console.ReadLine());

            FishUtility obj= new FishUtility();
            obj.AddFish(species, pricePerFish);

            if(obj.BuyFish())
            {
                Console.WriteLine("Enter the number fished you want?");
                int numberOfFishes= Convert.ToInt32(Console.ReadLine());
                double totalPrice= obj.CalculatePrice(numberOfFishes);
                Console.WriteLine($"Total price is {totalPrice}");
            }
            else
            {
                Console.WriteLine($"{species} species not found");
            }

        }
    }
}


/*
In  Program class, Main method (Method declaration is already provided)

Prompt the user to enter the Species and PricePerFish.
Call methods appropriately.
Then print the output as per the sample input and output.
Sample Input 1:

Enter the species to buy

Clownfish

Enter the price per fish

50

Enter the number of fishes you need to buy

35

 

Sample Output 1:

Total cost is 1850
*/
