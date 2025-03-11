using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculateCarPrice_Class_Object
{
    public class Car : Owner
    {
        internal double price;
        private string bodyStyle;
        public string BodyStyle
        {
            get{ return bodyStyle;}
            set{bodyStyle=value;}
        }

        public bool ValidateBodyStyle(string bodyStyle)
        {
            if(bodyStyle=="SUV" || bodyStyle=="Sedan")
             {
               return true;
             }
            return false;   

        }
        public double CalculatePrice()
        {
            if(bodyStyle=="SUV")
             
             {
                  double Tprice=this.price-(this.price* 10/100);
                  return Tprice;
             }
             else if(bodyStyle=="Sedan")
             {
                double TTprice=this.price-(this.price* 25/100);
                  return TTprice;
             }
             else{
                return 0;
             }

        }
        public void SetOwnerName(string name)
        {
            ownerName= name;
        }

    }
}