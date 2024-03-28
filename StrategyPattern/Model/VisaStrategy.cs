using Strategy_Pattern.Models.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.Models
{
    internal class VisaStrategy: iPayment
    {
        public bool Pay(decimal value)
        {
            Console.WriteLine("Bezahlung mit VISA");

            // hier verwenden wir die VISA-API
            return VisaAPI.PayWithVisa(value);
            //deswegen haben wir static verwendet

        }
    }
}
