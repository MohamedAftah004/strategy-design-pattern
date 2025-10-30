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

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public double CalculatePrice(MembershipType membershipType)
        {

            if (membershipType == MembershipType.REGULAR)
                return Price;
            else if(membershipType == MembershipType.GOLD)
                return Price * 0.9;
            else if(membershipType == MembershipType.PREMIUM)
                return Price * 0.8;

                return Price;
            
        }
    }
}
