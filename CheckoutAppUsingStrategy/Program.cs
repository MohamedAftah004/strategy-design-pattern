using CheckoutAppUsingStrategy;
using CheckoutAppUsingStrategy.Enum;
using CheckoutAppUsingStrategy.Interfaces;
using CheckoutAppUsingStrategy.Interfaces.Membership;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategy
{
    public class Program
    {

        public static void Main(string[] args)
        {
        
            Product product = new Product("Laptop", 1000 , new PremiumPricingStrategy());
            double laptopPrice = product.CalculatePrice(MembershipType.GOLD);
            Console.WriteLine($"Final Price for GOLD member: {laptopPrice}");
            Checkout checkout = new Checkout(new VisaCardPaymentStrategy());
            checkout.ProcessPayment(laptopPrice);

        }

    }
}
