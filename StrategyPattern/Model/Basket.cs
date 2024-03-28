using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.Models
{
    internal class Basket
    {
        public List<BasketItem> Basketitems { get; set; } = new List<BasketItem>();
        public Customer Customer { get; set; }

        //für Strategy-Pattern
        public iPayment PaymentMethod { get; set; } 
        //hier das interface verwenden

        //für Strategy-Pattern
        public bool PayBasket()
        {
            //diese Methode würde z.B. in einer Website aufgerufen 
            // wenn der Bezahlen button angeklickt wird 

            decimal totalPrice = this.Basketitems.Sum(bi => bi.Article.Price * bi.Amount);

            if (this.PaymentMethod !=null)
            {
                return PaymentMethod.Pay(totalPrice);
            }
            return false;
            
        }
    }
}
