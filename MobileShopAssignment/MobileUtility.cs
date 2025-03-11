using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShopAssignment
{
    public class MobileUtility
{
    public void AddMobileDetails(string model, string brand, int price)
    {
        int key = Program.mobileDetails.Count + 1;
        Program.mobileDetails.Add(key, new Mobile { Model = model, Brand = brand, Price = price });
        Console.WriteLine("\nMobile details added successfully\n");
    }

    public SortedDictionary<string, List<Mobile>> GroupMobilesByBrand()
    {
        SortedDictionary<string, List<Mobile>> groupedMobiles = new SortedDictionary<string, List<Mobile>>();
        
        foreach (var mobile in Program.mobileDetails.Values)
        {
            if (!groupedMobiles.ContainsKey(mobile.Brand))
            {
                groupedMobiles[mobile.Brand] = new List<Mobile>();
            }
            groupedMobiles[mobile.Brand].Add(mobile);
        }
        
        return groupedMobiles;
    }
}
}