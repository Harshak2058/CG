using System;
using System.Collections.Generic;
namespace HueHub_Collections
{
    public class Program
    {
        public static Dictionary<string,Color>ColorInventory{get;set;}= new Dictionary<string, Color>();
    public static void Main(string[] args)
    {
        ColorUtility utility= new ColorUtility();
        while(true)
        {
        Console.WriteLine("Enter the choice");
        Console.WriteLine("1. Add Color");
        Console.WriteLine("2 Remove color");
        Console.WriteLine("3.Exiting color managemenet system");
        string choice=Console.ReadLine();

        if(choice=="1")
        {
            Console.WriteLine("Enter the color name:");
            string name= Console.ReadLine();
            Console.WriteLine("Enter hex code");
            string hexCode= Console.ReadLine();
            Console.WriteLine("Enter the price");
            double pricePerLiter= Convert.ToDouble(Console.ReadLine());
            utility.AddColor(name, hexCode, pricePerLiter);
            Console.WriteLine($"Color {name} added successfully");
        }
        else if(choice == "2")
        {
            Console.WriteLine("Enter color name to remove:");
            string name= Console.ReadLine();
            bool isRemoved=utility.RemoveColor(name);
            if(isRemoved)
            {
                Console.WriteLine($"{name} Color removed");
            }
            else {
                Console.WriteLine($"{name}Color not removed");
            }
        }
        else if(choice =="3")
        {
            Console.WriteLine("Thank you");
            break;
        }

        }
    }

    }
}
