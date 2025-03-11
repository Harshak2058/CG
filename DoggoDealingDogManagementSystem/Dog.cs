using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoggoDealingDogManagementSystem
{
    public class Dog
    {
        public string Breed{get; set;}
        public double PricePerDog{get; set;}
    }
}
/*
Functional Requirements:

Implement the following public Properties in Dog class 

Property Name    Type

Breed             string
PricePerDog       double

 

 
In  Program class, Main method (Method declaration is already provided)

Prompt the user to enter the Breed and PricePerDog.
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

Enter the dog breed to buy:

Labrador

Enter the price per dog:

800

Enter the number of dogs you need to buy:

3

 

Sample Output 1:

Total cost is 2600

 

Sample Input 2:

Enter the dog breed to buy:

Bulldog

Enter the price per dog:

2000

 

Sample Output 2:

Bulldog breed not found
*/