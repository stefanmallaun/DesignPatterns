using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern2.Models
{
    internal class PaypalStrategy : iStrategy
    {
        public bool Pay(decimal amount)
        {
            Console.WriteLine("Wird mit Paypal bezahlt: " + amount);
            return true;
        }
    }
}
