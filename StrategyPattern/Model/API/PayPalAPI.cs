using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.Models.API
{
    // diese KLassen werden eigentlich von den Zahlungsmethoden zur Verfügung gestellt
    internal class PayPalAPI
    {
        public static bool PayWithPayPal(decimal value)
        {
            return true;
            // das würde das ausführen was paypal normal macht
        }
    }
}
