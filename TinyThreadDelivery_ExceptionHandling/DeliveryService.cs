using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TinyThreadDelivery_ExceptionHandling
{
    public class DeliveryService
    {
        public bool PlaceOrder(Product product)
        {
            if(product.Stock<=0)
            {
                throw new ProductOutOfStockException();
            }
            return true;

        }
    }
}