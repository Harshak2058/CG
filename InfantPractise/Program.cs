using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfantPractise
{
    public class Program
    {
        public static List<BabyDress> DressesCart{get; set;}= new List<BabyDress>();
        public static void Main(string[] args)
        {
            BabyDressUtility utility= new BabyDressUtility();
            while(true)
            {
                Console.WriteLine("Enter 1 to Add dress to cart");
                Console.WriteLine("Enter 2 to remove dress from cart");
                Console.WriteLine("Enter 3 to exit");
                Console.WriteLine("Enter the choice");
                string choice= Console.ReadLine();

                if(choice=="1")
                {
                    Console.WriteLine("Enter the size of the dress");
                    int size= int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the color of the dress");
                    string color= Console.ReadLine();
                    Console.WriteLine("Enter the Brand of the dress");
                    string brand= Console.ReadLine();
                    Console.WriteLine("Enter the price pf the dress");
                    double price= Convert.ToDouble(Console.ReadLine());
                    BabyDress dress= new BabyDress
                    {
                        size= size, color= color, brand= brand, price= price
                    };
                    utility.AddDressToCart(dress);
                }
                else if(choice =="2")
                {
                    Console.WriteLine("Enter brand of dress");
                    string brand = Console.ReadLine();
                    bool isRemoved= utility.Re
                }
            
        }

        
    }
}
