using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Models
{
    internal class Observer2 : iMyObserver
    {
        private StockSubject? _stock;
        public void Update()
        {
            if (this._stock != null)
            {
                Console.WriteLine("Observer2: " + _stock.Value);
            }
        }
        public Observer2() : this(null)
        {

        }
        public Observer2(StockSubject? stock)
        {
            this._stock = stock;
        }
    }
}
