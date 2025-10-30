using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutAppUsingStrategy.Interfaces.Membership
{
    public class PremiumPricingStrategy : PricingStrategy
    {
        public double CalculatePrice(double price)
        {
            return price * 0.8; // 30% discount for PREMIUM members
        }
    }
}
