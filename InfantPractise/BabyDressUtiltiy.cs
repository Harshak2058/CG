using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfantPractise
{
    public class BabyDressUtiltiy
    {
        public void AddDressToCart(BabyDress dress)
        {
            Program.BabyDress(dress);
        }
        public bool RemoveDressFromCart(string brand)
        {
            BabyDress dressToRemove= Program.DressesCart.Find(d=>d.Brand= brand);
            if(dressToRemove!= null)
            {
                Program.DressesCart.Remove(dressToRemove);
                return true;
            }
            return false;
        }
        
    }
}