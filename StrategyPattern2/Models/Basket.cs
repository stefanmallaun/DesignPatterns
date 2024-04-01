using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern2.Models
{
    internal class Basket
    {
        public List<Item> Items{ get; set; } 

        public iStrategy PaymentMethode { get; set; }

        public bool PayNow()
        {
            decimal totalprice = Items.Count();
            if(this.PaymentMethode != null)
            {
                return PaymentMethode.Pay(totalprice);
            }
            return false;
        }
    }
}
