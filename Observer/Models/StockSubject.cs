using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Models
{
    internal class StockSubject : Subject
    {
        // dieser Wert ändert sich unregelmäßig 
        //      muss ein normales Propertie sein
        private decimal _value;
        private decimal _wert;

        // Name ändert sich nicht (Name der Aktie)
        public string Name { get; set; }
        public decimal Value { 
            get { return _value; } 
            set { 
                // nur wenn sich der Wert geändert hat (geringere Aufwand, idk)
                if (value != this._value) {
                    // Wert neu setzen und
                    decimal _wert = value;
                    this._value = value; 
                    // alle Observer verständigen
                    if(this._value - value > 50) { 
                    this.Notify();
                    }
                }
            } 
        }
        // Decimal für Preisbeträge
        // Double Kommazahlen
        public StockSubject() : this("-", 0.0m, 0.0m) { }
        public StockSubject(string name, decimal value, decimal wert)
        {
            this.Name = name;
            this._value= value;
            this._wert = wert;
        }

        // ToString()
        public override string ToString()
        {
            return this.Name +": " + this._value +" Euro";
        }



    }
}
