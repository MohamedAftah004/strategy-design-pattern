using CheckoutAppUsingStrategy.Enum;
using CheckoutAppUsingStrategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategy
{
    public class Product
    {

        private string Name;
        private double Price;

        private readonly PricingStrategy _pricingStrategy;
        public Product(string name, double price , PricingStrategy pricingStrategy)
        {
            Name = name;
            Price = price;
            _pricingStrategy = pricingStrategy;
        }

        public double CalculatePrice(MembershipType membershipType)
        {
            return _pricingStrategy.CalculatePrice(Price);
        }
    }
}
