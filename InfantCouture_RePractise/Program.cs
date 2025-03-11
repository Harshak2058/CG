using System;
namespace InfantCouture_RePractise
{
    public class Program
    {
        public static List<BabyDress> DressesCart{get;set;}= new List<BabyDress>();
        public static void Main()
        {
            BabyDressUtility utility= new BabyDressUtility();
            while(true)
            {
                Console.WriteLine("1. Add dress to cart");
                Console.WriteLine("2. Remove dress from cart");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Enter the choice");
                string choice = Console.ReadLine();

                if(choice=="1")
                {
                    Console.WriteLine("Enter the dress size");
                    int size= Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the dress color");
                    string color= Console.ReadLine();
                    Console.WriteLine("Enter the dress brand");
                    string brand= Console.ReadLine();
                    Console.WriteLine("Enter the dress price");
                    double price= Convert.ToDouble(Console.ReadLine());
                    
                    BabyDress dress= new BabyDress
                    {
                        Size=size, Color=color, Brand=brand, Price=price 
                    };
                    utility.AddDressToCart(dress);
                    Console.WriteLine("Successfully added to the dress cart");
                }
                else if(choice=="2")
                {
                    Console.WriteLine("Enter the brand of the dress");
                    string brand= Console.ReadLine();
                    bool check=utility.RemoveDressFromCart(brand);
                    if(check)
                    {
                        Console.WriteLine("Successfully removed from the cart");
                    }
                    else{
                        Console.WriteLine("Dress not found in the cart");
                        
                    }
                }
                else if(choice=="3")
                {
                    Console.WriteLine("Thank You");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }

            }



        }
    }

}
