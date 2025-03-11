using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mockSeaInhabitant
{
    public class FishUtility : Fish
    {
        public void AddFish(string species, double pricePerFish)
        {
            Species= species;
            PricePerFish= pricePerFish;
        }
        public bool BuyFish()
        {
            if(Species=="Clownfish" || Species=="Goldfish")
            return true;
        return false;
        }
        public double CalculatePrice(int numberOfFishes)
        {
            
            if(Species=="Clownfish")
            {
                double totalPrice= (numberOfFishes * PricePerFish) + 100;
                return totalPrice;
            }
            else if(Species=="Goldfish")
            {
                 double ttotalPrice= (numberOfFishes * PricePerFish) + 150; 
                return ttotalPrice;
            }
            else
            {
                return 0;
            }
        }
    }
}