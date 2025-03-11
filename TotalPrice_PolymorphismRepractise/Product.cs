using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TotalPrice_PolymorphismRepractise
{
    public class Product
    {
        public decimal CalculateTotalPrice(decimal price, int quantity)
        {
            decimal cal1= price * quantity;
            return cal1;

        }
        public decimal CalculateTotalPrice(decimal price, int quantity, int discountPercentage)
        {
            decimal totalPrice= price * quantity;
            decimal disAmountt= totalPrice * discountPercentage/100;
            return totalPrice-disAmountt;
/* formula
Total Price With Discount =
 (price * quantity)- 
 (price * quantity * discount percentage/100).
*/
        }
    }
}