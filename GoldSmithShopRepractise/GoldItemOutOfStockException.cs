using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoldSmithShopRepractise
{
    public class GoldItemOutOfStockException: Exception
    {
        public GoldItemOutOfStockException():base ("Gold Item is out of stock"){}
    }
}