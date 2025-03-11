using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace product
{
    public class Program
    {
         public static void Main(string[] args)
    {
 
        Console.WriteLine("Enter the ID of Product");
        int id = Convert.ToInt32(Console.ReadLine());
 
        Console.WriteLine("Enter the Product Name");
        string name = Console.ReadLine();
 
        Console.WriteLine("Enter the Product Type");
        string department = Console.ReadLine();
 
 
        Product pd = new Product(id, name, department);
 
        pd.DisplayDetails();
    }.
    }
}