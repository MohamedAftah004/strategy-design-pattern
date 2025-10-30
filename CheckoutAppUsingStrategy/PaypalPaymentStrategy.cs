using CheckoutAppUsingStrategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutAppUsingStrategy
{
    public class PaypalPaymentStrategy : PaymentStrategy
    {
        public void ProcessPayment(double amount)
        {

            Console.WriteLine("Processing Payment of paypal...");
            Console.WriteLine("Calculating fees of the amount " + amount + " for paypal...");


        }
    }
}
