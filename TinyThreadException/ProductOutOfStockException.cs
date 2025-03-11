using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TinyThreadException
{
    public class ProductOutOfStockException : Exception
    {
        public ProductOutOfStockException(): base("product if out of stock"){}
    }
}