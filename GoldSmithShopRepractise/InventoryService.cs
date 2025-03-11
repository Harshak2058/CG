using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoldSmithShopRepractise
{
    public class InventoryService
    {
        public bool PlaceOrder(GoldItem goldItem)
        {
            if(goldItem.Stock <=0)
            throw new GoldItemOutOfStockException();
            return true;
        }
    }
}