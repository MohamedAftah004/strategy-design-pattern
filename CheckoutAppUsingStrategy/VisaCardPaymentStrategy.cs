using CheckoutAppUsingStrategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutAppUsingStrategy
{
    public class VisaCardPaymentStrategy : PaymentStrategy
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine("Processing Payment of visa card...");
            Console.WriteLine("Calculating fees of the amount " + amount + " for visa cards...");
        }
    }
}
