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
        
            Product product = new Product("Laptop", 1000);
            Console.WriteLine("Real Price : " + product.CalculatePrice(MembershipType.REGULAR));
            double laptopPrice = product.CalculatePrice(MembershipType.GOLD);
            Console.WriteLine($"Final Price for GOLD member: {laptopPrice}");
            Checkout checkout = new Checkout();
            checkout.ProcessPayment(laptopPrice, PaymnetMethod.PAYPAL);

        }

    }
}
