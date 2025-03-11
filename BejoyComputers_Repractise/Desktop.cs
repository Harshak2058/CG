using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BejoyComputers_Repractise
{
    public class Desktop: Computer
    {
        public int MonitorSize{get;set;}
        public int PowerSupplyVolt{get;set;}

        public double DesktopPriceCalculation()
        {
            if(this.Processor=="i3")
            {
                double DesktopPrice= 1500+ (this.RamSize * 200)+(this.HardDiskSize * 1500)+(this.GraphicCardSize * 2500)+(this.MonitorSize * 250)+(this.PowerSupplyVolt * 20);
                return DesktopPrice;
            }
            else if(this.Processor=="i5")
            {
                double DesktopPrice= 3000+ (this.RamSize * 200)+(this.HardDiskSize * 1500)+(this.GraphicCardSize * 2500)+(this.MonitorSize * 250)+(this.PowerSupplyVolt * 20);
                 return DesktopPrice;
            }
            else if(this.Processor=="i7")
            {
                double DesktopPrice= 4500+ (this.RamSize * 200)+(this.HardDiskSize * 1500)+(this.GraphicCardSize * 2500)+(this.MonitorSize * 250)+(this.PowerSupplyVolt * 20);
                return DesktopPrice;
            }
            else{
                 return 0;
            }


        }
    }
}