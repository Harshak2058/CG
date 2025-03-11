using System;


namespace PetShopFishInventoryManagement
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
            return Species=="Clownfish" || Species=="Goldfish";
        }
        public double CalculatePrice(int numberOfFishes)
        {
            double AdditionalPrice= Species=="Clownfish"?100:150;
            return (PricePerFish * numberOfFishes )+AdditionalPrice;
        }
    }
}
/*
In the FishUtility class, implement the below given public methods. FishUtility class   should inherit the Fish class.

Method Declaration

1)public void AddFish(string species, double pricePerFish)
Description:
This method is used to set the values to the properties of the Fish class.

2)public bool BuyFish()
Description:
This method is used to validate if the specified fish species property is valid for buying.

If the species is "Clownfish" or "Goldfish", return true; Otherwise return false.(species is Case-Sensitive)

If this method returns false, print "{Species} species not found" in Main method.

3)public double CalculatePrice(int numberOfFishes)
Description:
This method calculates the total price of the fishes and returns it.

To calculate the total price, multiply the numberOfFishes with price per fish and add the additional charges for packing.


Species

Additional charges

Clownfish

100

Goldfish

150


*/

