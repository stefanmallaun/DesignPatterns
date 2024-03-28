using Strategy_Pattern.Models.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.Models
{
    internal class PayPalStrategy : iPayment
    {
        public bool Pay(decimal value)
        {
            Console.WriteLine("Bezahlung mit Paypal");

            // hier verwenden wir die PayPalAPI
            return PayPalAPI.PayWithPayPal(value);
            //deswegen haben wir static verwendet
            
        }
    }
}
