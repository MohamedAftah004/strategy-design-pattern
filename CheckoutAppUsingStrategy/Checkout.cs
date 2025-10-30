using CheckoutAppUsingStrategy.Enum;
using CheckoutAppUsingStrategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategy
{
    public class Checkout
    {

        private readonly PaymentStrategy _paymentStrategy;

        public Checkout(PaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }

        public void ProcessPayment(double amount)
        {
            _paymentStrategy.ProcessPayment(amount);
        }



    }
}
