using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoggoDealingRepractise
{
    public class DogUtility : Dog
    {
        public void AddDog(string breed, double pricePerDog)
        {
            Breed= breed;
            PricePerDog = pricePerDog; 
        }
        public bool BuyDog()
        {
            if(Breed=="Labrador"|| Breed=="Poodle"|| Breed =="German Shepherd")
            {
                return true;
            }
            return false;
        }
        public double CalculatePrice(int numberOfDogs)
        {
            int additionalGroomCharge= 200;
            double totalPrice= (numberOfDogs * PricePerDog)+ additionalGroomCharge;
            return totalPrice;
        }
        
    }
}