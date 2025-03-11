using System;
namespace CalculateCarPrice_Class_Object
{
    public class Program
    {
        public static void Main()
        {

            Console.WriteLine("Enter the owner name:");
            string on = Console.ReadLine();

            Console.WriteLine("Enter the car body style:");
            string bodyStyle=Console.ReadLine();
            Console.WriteLine("Enter the price");
            double p= Convert.ToDouble(Console.ReadLine());

            Car c= new Car();
                c.BodyStyle= bodyStyle ; 
                c.price =p;

            
            bool check= c.ValidateBodyStyle(c.BodyStyle);
            if(check)
            {
                double finalPrice= c.CalculatePrice();
                c.SetOwnerName(on);
                Console.WriteLine($"The owner sells the {c.BodyStyle} type car for ${finalPrice}");
            }
            else{
                Console.WriteLine("Invalid Car Type");
            }
        }

    }
}
