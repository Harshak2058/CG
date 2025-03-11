using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TinyThreadException
{
    public class DeliveryService 
    {
        public bool PlaceOrder(Product product)
        {
            if(product.Stock<=0)
            throw new ProductOutOfStockException();//"Product is out of stock");
            else //if(product.Stock>0)
            {
                return true;
            }
        }
    }
}