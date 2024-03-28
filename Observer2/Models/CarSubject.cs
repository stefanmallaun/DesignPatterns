using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer2.Models {
    internal class CarSubject : Subject{
        
        private decimal _kmh;
        

        // Name ändert sich nicht (Name der Aktie)
        public string Name { get; set; }
        public decimal Value {
            get { return _kmh; }
            set {
                
                if (value != this._kmh) {
                   
                    decimal _wert = value;
                    this._kmh = value;
                        this.Notify();
                    
                }
            }
        }
        
        public CarSubject() : this("-", 0.0m) { }
        public CarSubject(string name, decimal value) {
            this.Name = name;
            this._kmh = value;
            
        }

        // ToString()
        public override string ToString() {
            return this.Name + ": " + this._kmh + " Kmh";
        }


    }
}
