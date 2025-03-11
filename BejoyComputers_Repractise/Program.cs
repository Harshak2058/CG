using System;
namespace BejoyComputers_Repractise
{
    public class Program
    {
        public static void Main()
        {
            // Desktop d = new Desktop();
            // Laptop l = new Laptop();
            
            Console.WriteLine("1.Desktop");
            Console.WriteLine("2.Laptop");
            Console.WriteLine("Choose the option");

            string choice = Console.ReadLine();
            Console.WriteLine("Enter the processor");
                string processor = Console.ReadLine();
                Console.WriteLine("Enter the ram Size");
                int ramSize= int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the hard disk size");
                int hardDiskSize= int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the graphic card size");
                int graphicCardSize=int.Parse(Console.ReadLine());
                
            if(choice=="1")
            {
               
                Console.WriteLine("Enter the monitor size");
                int monitorSize= int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the power supply volt");
                int powerSupplyVolt= int.Parse(Console.ReadLine());
                 Desktop d = new Desktop
                {
                    Processor = processor,
                    RamSize = ramSize,
                    HardDiskSize = hardDiskSize,
                    GraphicCardSize = graphicCardSize,
                    MonitorSize = monitorSize,
                    PowerSupplyVolt = powerSupplyVolt
                };
                    // d.Processor =processor;
                    // d.RamSize=ramSize;
                    // d.HardDiskSize=hardDiskSize;
                    // d.GraphicCardSize=graphicCardSize;
                    // d.MonitorSize= monitorSize;
                    // d.PowerSupplyVolt=powerSupplyVolt;
               
                double final_DesktopPrice=d.DesktopPriceCalculation();
                Console.WriteLine("Desktop price is "+final_DesktopPrice);
            }
            else if(choice =="2")
            {
                Console.WriteLine("Enter the display size");
                int displaySize= int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the battery volt");
                int batteryVolt= int.Parse(Console.ReadLine());
               Laptop l = new Laptop
                {
                    Processor = processor,
                    RamSize = ramSize,
                    HardDiskSize = hardDiskSize,
                    GraphicCardSize = graphicCardSize,
                    DisplaySize = displaySize,
                    BatteryVolt = batteryVolt
                };
                //  l.Processor =processor;
                //   l.RamSize=ramSize;
                //    l.HardDiskSize=hardDiskSize;
                //   l.GraphicCardSize=graphicCardSize;

                //  l.DisplaySize= displaySize;
                //   l.BatteryVolt=batteryVolt;   
              
               double final_LaptopPrice= l.LaptopPriceCalculation();
               Console.WriteLine("Laptop price is "+final_LaptopPrice);
            }
            else{
                Console.WriteLine("Invalid input");
            }
        }
    }
}
