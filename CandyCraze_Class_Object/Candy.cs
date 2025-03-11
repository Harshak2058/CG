using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyCraze_Class_Object
{
    public class Candy
    {
        public string Flavour{get;set;}
        public int Quantity{get;set;}
        public int PricePerPiece{get;set;}
        public double TotalPrice{get;set;}
        public double Discount{get;set;}

        public bool ValidateCandyFlavour()
        {
            if(Flavour=="Strawberry" || Flavour=="Lemon" || Flavour=="Mint")
            {
                return true;
            }
            return false;
        }
    }
}