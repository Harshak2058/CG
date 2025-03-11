using System;
using System.Collections.Generic;



public class Program
{
    public static SortedDictionary<int, Mobile> mobileDetails = new SortedDictionary<int, Mobile>();

    public static void Main()
    {
        MobileUtility utility = new MobileUtility();
        while (true)
        {
            Console.WriteLine("1. Add Mobile Details");
            Console.WriteLine("2. Group Mobiles By Brand");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter the model: ");
                    string model = Console.ReadLine();
                    Console.Write("Enter the brand: ");
                    string brand = Console.ReadLine();
                    Console.Write("Enter the price: ");
                    int price = int.Parse(Console.ReadLine());
                    utility.AddMobileDetails(model, brand, price);
                    break;
                
                case 2:
                    var groupedMobiles = utility.GroupMobilesByBrand();
                    foreach (var brandEntry in groupedMobiles)
                    {
                        Console.WriteLine($"\n{brandEntry.Key}\n");
                        foreach (var mobile in brandEntry.Value)
                        {
                            Console.WriteLine(mobile.Model);
                        }
                    }
                    Console.WriteLine();
                    break;
                
                case 3:
                    Console.WriteLine("Thank you");
                    return;
                
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}

