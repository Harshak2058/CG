using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfantCouture_RePractise
{
    public class BabyDressUtility
    {
        public void AddDressToCart(BabyDress dress)
        {
            Program.DressesCart.Add(dress);

        }
        public bool RemoveDressFromCart(string brand)
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