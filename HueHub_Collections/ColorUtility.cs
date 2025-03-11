using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HueHub_Collections
{
    public class ColorUtility
    {
        public void AddColor(string name, string hexCode, double pricePerLiter)
        {
            // Program.ColorInventory[name]= new Color
            // {
            //     Name=name,
            //     HexCode = hexCode,
            //     PricePerLiter=pricePerLiter
            // };
            if (!Program.ColorInventory.ContainsKey(name))
        {
            Program.ColorInventory[name] = new Color 
            { Name = name, 
            HexCode = hexCode, 
            PricePerLiter = pricePerLiter };
            Console.WriteLine("Color added successfully!");
        }
        else
        {
            Console.WriteLine("Color already exists.");
        }

        }
        public bool RemoveColor(string name)
        {
            if (Program.ColorInventory.ContainsKey(name))
            {
                Program.ColorInventory.Remove(name);
                return true;
            }
         return false;
        }
    }
}