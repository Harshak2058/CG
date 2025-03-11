using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BejoyComputers_Repractise
{
    public class Laptop : Computer
    {
        public int DisplaySize{get;set;}
        public int BatteryVolt{get;set;}        

        public double LaptopPriceCalculation()
        {
            if(this.Processor=="i3")
            {
                 double LaptopPrice= 2500+ (this.RamSize * 200)+(this.HardDiskSize * 1500)+(this.GraphicCardSize * 2500)+(this.DisplaySize * 250)+(this.BatteryVolt * 20);
               return LaptopPrice;
            }
            else if(this.Processor=="i5")
            {
                 double LaptopPrice= 5000+ (this.RamSize * 200)+(this.HardDiskSize * 1500)+(this.GraphicCardSize * 2500)+(this.DisplaySize * 250)+(this.BatteryVolt * 20);
               return LaptopPrice;
            }
            else if(this.Processor=="i7")
            {
                 double LaptopPrice= 6500+ (this.RamSize * 200)+(this.HardDiskSize * 1500)+(this.GraphicCardSize * 2500)+(this.DisplaySize * 250)+(this.BatteryVolt * 20);
               return LaptopPrice;
            }
            else{
                return 0;
            }
        }
    }
}