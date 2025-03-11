using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace InfantCoutureBabyDressManagement
{
    public class Program
    {
        public static List<BabyDress> DressesCart { get; set; } = new List<BabyDress>();
        public static void Main(string[] args)
        {
            BabyDressUtility utility= new BabyDressUtility();
            while(true)
            {
            Console.WriteLine("Enter 1 to add dress");
            Console.WriteLine("Enter 2 to remove dress");
            Console.WriteLine("Enter 3 to exit");
            
            Console.WriteLine("Enter the choice");
            string choice= Console.ReadLine();
            if(choice=="1")
            {
                Console.WriteLine("Enter the size of dress");
                int size=int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the color of the dress");
                string color= Console.ReadLine();
                Console.WriteLine("Enter the brand of the dress");
                string brand= Console.ReadLine();
                Console.WriteLine("Enter the price of the dress");
                double price= Convert.ToDouble(Console.ReadLine());
                BabyDress dress= new BabyDress
                {
                    Size=size,Color=color, Brand=brand, Price=price 
                };
                utility.AddDressToCart(dress);
                Console.WriteLine("Successfully added to cart");
            }
            else if(choice=="2")
            {
                Console.WriteLine("Enter the brand to remove");
                string brand= Console.ReadLine();
                bool isRemoved=utility.RemoveDressToCart(brand);
                if(isRemoved)
                {
                    Console.WriteLine("Successfully removed from cart");
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
            }
        }
    }
}

/*
In Program class,

public static List<BabyDress> DressesCart { get; set; } = new List<BabyDress>() - This is already provided in the code template.

Method1:
public static void Main(string[] args)
Description1:
1) Prompt the user to enter their choice from a list of options.

2) For choice 1, prompt the user to enter the details of the dress and call the AddDressToCart method and print "Successfully added to the dress cart".

3) For choice 2, prompt the user to enter the brand of the dress they want to remove and call the RemoveDressFromCart method.

-         If this method returns true, print "Successfully removed from the cart".

-         If this method returns false, print "Dress not found in the cart".

4) For choice 3, exit the program and print "Thank you!".

Note: Output is Case-Sensitive.

Refer to Sample input and output.

 

Note:

-         Keep all methods public.

-         Do not use Environment.Exit() to terminate the program.

-         Do not change the given code template.

-         In the Sample Input / Output provided, the highlighted text in bold corresponds to the input given by the user, and the rest of the text represents the output.

-        Input should only be gathered in the Main method. 

 

Sample Input/Output 1:

1. Add dress to cart

2. Remove dress from cart

3. Exit

Enter your choice

1

Enter the dress size

6

Enter the dress color

Blue

Enter the dress brand

BabyGap

Enter the dress price

30

 

Successfully added to the dress cart

 

1. Add dress to cart

2. Remove dress from cart

3. Exit

Enter your choice

1

Enter the dress size

9

Enter the dress color

Pink

Enter the dress brand

Carter's

Enter the dress price

25

 

Successfully added to the dress cart

 

1. Add dress to cart

2. Remove dress from cart

3. Exit

Enter your choice

2

Enter the dress brand to remove the dress from cart

BabyGap

 

Successfully removed from the cart

 

1. Add dress to cart

2. Remove dress from cart

3. Exit

Enter your choice

2

Enter the dress brand to remove the dress from cart

Oshkosh

 

Dress not found in the cart

 

1. Add dress to cart

2. Remove dress from cart

3. Exit

Enter your choice

3

 

Thank you!
*/