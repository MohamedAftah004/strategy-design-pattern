using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutAppUsingStrategy.Interfaces.Membership
{
    public class RegularPricingStrategy : PricingStrategy
    {
        public double CalculatePrice(double price)
        {
            return price; 
        }
    }
}
