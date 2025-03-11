using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeShop_ExceptionRepractise
{
    public class InvalidFlavourException: Exception
    {
        public InvalidFlavourException(): base("Flavour not available. Please select the available flavour "){}
        
    }
}