using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfantCoutureBabyDressManagement
{
    public class BabyDressUtility //: BabyDress
    {
        public void AddDressToCart(BabyDress dress)
        {
            Program.DressesCart.Add(dress);
        }
        public bool RemoveDressToCart(string brand)
        {
           BabyDress dressToRemove= Program.DressesCart.Find(d=>d.Brand==brand);
           if(dressToRemove!=null)
           {
            Program.DressesCart.Remove(dressToRemove);
            return true;
           }
           return false;

        }
    }
}
/*
In the  BabyDressUtility class, implement the below-given public  methods.

Method Declaration
1)public void AddDressToCart(BabyDress dress)
Description:
This method adds a dress to the shopping cart. It adds the given BabyDress object to the DressesCart list in the program class.
This method returns  void.

2)public bool RemoveDressFromCart(string brand)
Description:
This method removes a dress from the shopping cart based on its brand.
If the brand is found, remove the dress from the DressesCart list, it returns true.
If the brand is not found, it returns false.
Refer to sample input and output.

*/