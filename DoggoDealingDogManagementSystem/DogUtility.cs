using System;


namespace DoggoDealingDogManagementSystem
{
    public class DogUtility : Dog
    {
        public void AddDog(string breed, double pricePerDog)
        {
            Breed= breed;
            PricePerDog= pricePerDog; 
        }
        public bool BuyDog()
        {
            return Breed=="Labrador" || Breed =="Poodle" || Breed=="German Shepherd";
        }

        public double CalculatePrice(int numberOfDogs)
        {
            int AdditionalCharges=200;
            return (numberOfDogs * PricePerDog)+ AdditionalCharges;

        }

    }
}
/*
In the DogUtility class, implement the below given public methods. DogUtility class should inherit the Dogclass.
Method Declaration
1)public void AddDog(string breed, double pricePerDog)
Description:
This method is used to set the values to the properties of the Dog class.
2)public bool BuyDog()
Description:
This method is used to validate if the specified dog breed property is valid for buying.
If the breed is "Labrador" or "Poodle" or "German Shepherd", return true; Otherwise return false.(Breed is Case-Sensitive)
If this method returns false, print "{Breed} breed not found" in Main method.
3)public double CalculatePrice(int numberOfDogs)
This method calculates the total price of the dogs and returns it.
To calculate the total price, multiply the numberOfDogs with price per dog and add the additional charges of 200 for grooming.


*/