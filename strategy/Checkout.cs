using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategy
{
    public class Checkout
    {

        public void ProcessPayment(double amount , PaymnetMethod paymentMethod)
        {
            if(paymentMethod == PaymnetMethod.VISA_CARD)
            { 
                Console.WriteLine("Processing Payment of visa card...");
                Console.WriteLine("Calculating visa of the amount for visa card...");
            }
            else if (paymentMethod ==  PaymnetMethod.PAYPAL)
            {
                Console.WriteLine("Processing Payment of paypal...");
                Console.WriteLine("Calculating visa of the amount for paypal...");
            }
            else if (paymentMethod == PaymnetMethod.BANK_TRANSFER)
            {
                Console.WriteLine("Processing Payment of bank transfer...");
            }
        }

    }
}
