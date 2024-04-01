
using StrategyPattern2.Models;

namespace StrategyPattern2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Item i1 = new Item("Asdf");
            Item item2 = new Item("asdf");

            Basket b1 = new Basket();

            b1.Items.Add(i1);
            b1.Items.Add(item2);

            b1.PaymentMethode = new PaypalStrategy();


        
        
        
        }
    }
}
