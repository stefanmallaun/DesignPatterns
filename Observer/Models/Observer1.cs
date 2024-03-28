using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Models
{
    internal class Observer1 : iMyObserver
    {
        private StockSubject? _stock;
        private decimal _wert;
        public void Update()
        {
            if(this._stock != null && this._stock.Value > this._wert )
            {   
                Console.WriteLine("Observer1: " + _stock.Name + " - "+_stock.Value);
            }
        }
        public Observer1() : this(null, 0.0m)
        {

        }
        public Observer1(StockSubject? stock, decimal _wert)
        {
            this._stock = stock;
            this._wert = _wert;
        }
    }
}
