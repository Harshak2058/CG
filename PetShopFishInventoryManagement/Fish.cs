using System;


namespace PetShopFishInventoryManagement
{
    public class Fish
    {
        public string Species{get; set;}
        public double PricePerFish{get; set;}
    }
}
/*

Functional Requirements:

Implement the following public Properties in Fish class 

Property Name  Type

Species        string

PricePerFish   double

 

 
In  Program class, Main method (Method declaration is already provided)

Prompt the user to enter the Species and PricePerFish.
Call methods appropriately.
Then print the output as per the sample input and output.

Hint : Refer to sample input and output
 

Note:

-        Keep all methods public.

-        Do not use Environment.Exit() to terminate the program.

-        Do not change the given code template.

-         You should only get the input/output in the  Main method only.

-         Output is case-sensitive.

-         In the Sample Input / Output provided, the highlighted text in bold corresponds to the input given by the user, and the rest of the text represents the output.

 

Sample Input 1:

Enter the species to buy

Clownfish

Enter the price per fish

50

Enter the number of fishes you need to buy

35

 

Sample Output 1:

Total cost is 1850

 

Sample Input 2:

Enter the species to buy

Fighter

Enter the price per fish

60

 

Sample Output 2:

Fighter species not found

 


*/