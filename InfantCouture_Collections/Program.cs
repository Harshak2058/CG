using System;
using System.Collections.Generic;
namespace InfantCouture_Collections
{
    public class Program
    {

        public static List<BabyDress> DressesCart { get; set; } = new List<BabyDress>() ;
        
        public static void Main()
        {
            BabyDressUtility utility= new BabyDressUtility();

            while(true)
            {
            Console.WriteLine("Enter the choice from the list:");
            Console.WriteLine("1. Add dress to cart");
            Console.WriteLine("2. Remove dress from cart");
            Console.WriteLine("3. Exit");
            Console.WriteLine("4. View Dress");
            string choice=Console.ReadLine();
            if(choice=="1")
            {
                
                Console.WriteLine("Enter the dress size");
                int size=int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the dress color");
                string color= Console.ReadLine();
                Console.WriteLine("Enter the dress brand");
                string brand=Console.ReadLine();
                Console.WriteLine("Enter the dress price");
                double price= Convert.ToDouble(Console.ReadLine());
                 
                
                BabyDress dress= new BabyDress
                {
                    Size=size, Color= color,Brand= brand, Price=price  
                };
                utility.AddDressToCart(dress);
                Console.WriteLine("Dress added successfully");
                
            }
            else if(choice=="2")
            {
                Console.WriteLine("Enter the dress brand");
                string brand= Console.ReadLine();

                bool check=utility.RemoveDressFromCart(brand);
                if(check)
                {
                    Console.WriteLine("removed");
                }
                else{
                    Console.WriteLine("Not removed");
                }
            }
            else if(choice=="3")
            {
                Console.WriteLine("Thank you");
                break;
            }
            else if(choice =="4"){
                utility.ViewDress();
                //Console.WriteLine("Invalid input");
                }
            
            }  
        }
    }
}
