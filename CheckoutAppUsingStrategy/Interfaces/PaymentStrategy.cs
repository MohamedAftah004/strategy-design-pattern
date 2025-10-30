using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutAppUsingStrategy.Interfaces
{
    public interface PaymentStrategy 
    {
        void ProcessPayment(double amount);
    }
}
