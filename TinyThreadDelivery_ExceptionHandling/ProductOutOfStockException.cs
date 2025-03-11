using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TinyThreadDelivery_ExceptionHandling
{
    public class ProductOutOfStockException : Exception
    {
        public ProductOutOfStockException() : base("Product is out of stock"){}
        
    }
}