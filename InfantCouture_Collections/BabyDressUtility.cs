using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfantCouture_Collections
{
    public class BabyDressUtility
    {
        public void AddDressToCart(BabyDress dress)
        {
            Program.DressesCart.Add(dress);
            /*It adds the given 
            BabyDress object to the DressesCart list
             in the program class.*/
             //louis pillippie shhirt
        }

        public bool RemoveDressFromCart(string brand)
        {
            BabyDress dressToRemove=Program.DressesCart.Find(d=>d.Brand==brand);
            if(dressToRemove!=null)
            {
                Program.DressesCart.Remove(dressToRemove);

               return true;
            }
            return false;
        }
        public void ViewDress()
        {
             Console.WriteLine("Brand     | Size | Color  | Price");
    Console.WriteLine("--------------------------------");

    foreach (var item in Program.DressesCart)
    {
        Console.WriteLine($"{item.Brand,-10} | {item.Size,-4} | {item.Color,-6} | ${item.Price,6:F2}");
    }
        }
    }
}