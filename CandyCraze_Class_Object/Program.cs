using System;


namespace CandyCraze_Class_Object
{

    public class Program
    {
        public Candy CalculateDiscountedPrice(Candy candy)
        {
            candy.TotalPrice= candy.Quantity * candy.PricePerPiece;
            if(candy.Flavour=="Strawberry")
            {
                candy.Discount= candy.TotalPrice-(candy.TotalPrice*15/100);
            }
            else if(candy.Flavour=="Lemon")
            {
                candy.Discount= candy.TotalPrice-(candy.TotalPrice*10/100);
            }
            else if(candy.Flavour=="Mint")
            {
                candy.Discount= candy.TotalPrice-(candy.TotalPrice*5/100);
            }

            return candy;



        }
        public static void Main()
        {
            Program p= new Program();
            Console.WriteLine("Enter the flavour");
            string flavour= Console.ReadLine();
            Console.WriteLine("Enter the quantity");
            int quantity= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the price per piece");
            int pricePerPiece= int.Parse(Console.ReadLine());
            Candy candy= new Candy
            {
                Flavour= flavour, Quantity= quantity, PricePerPiece = pricePerPiece
            };
           bool check=candy.ValidateCandyFlavour();
           if(check)//true
           {
               p.CalculateDiscountedPrice(candy);
               Console.WriteLine($"Flavour is {candy.Flavour} ");
               Console.WriteLine($"Quantity is {candy.Quantity}");
               Console.WriteLine($"Price per piece is {candy.PricePerPiece}");
               Console.WriteLine($"Total Price is {candy.TotalPrice}");
               Console.WriteLine($"Discount is {candy.Discount}");

           }
           else{
            Console.WriteLine("Invalid flavour");
           }

        }
    }
}