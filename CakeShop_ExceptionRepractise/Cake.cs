using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeShop_ExceptionRepractise
{
    public class Cake
    {
        public string Flavour{get;set;}
        public int QuantityInKg{get;set;}
        public double PricePerKg{get;set;}

        public bool CakeOrder()
        {
            if(QuantityInKg>0)
            {
                if(Flavour=="Chocolate" || Flavour=="Red Velvet"|| Flavour=="Vanilla")
                  {
                    Console.WriteLine("Cake ordered successfully");
                    
                    return true;
                  }
                else
                 {
                    throw new InvalidFlavourException();
                 }
                 return true;
            }
            else{
                Console.WriteLine("Quantity must be greater than zero");
                return false;
            }

        }
        public double CalculatePrice()
        {
            if(Flavour=="Vanilla")
            {
                double TotalPrice= QuantityInKg * PricePerKg;
                double DiscountedPrice=TotalPrice- (TotalPrice* 3/100);
                return DiscountedPrice;
            }
            else if(Flavour =="Chocolate")
            {
                double TotalPrice= QuantityInKg * PricePerKg;
                double DiscountedPrice=TotalPrice- (TotalPrice* 5/100);
                return DiscountedPrice;
            }
            else if(Flavour=="Red Velvet")
            {
                double TotalPrice= QuantityInKg * PricePerKg;
                double DiscountedPrice=TotalPrice- (TotalPrice* 10/100);
                return DiscountedPrice;
            }
            else{
                return 0;
            }

        }
    }
}