using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer2.Models {
    internal class Observer : iMyObserver {
        private CarSubject? _car;
        
        public void Update() {
            if (this._car != null) {
                Console.WriteLine("Observer1: " + _car.Name + " - " + _car.Value);
                if(this._car.Value > 110) { 
                Console.WriteLine("ALARMMMMMMMMM");

                }

            }
        }
        public Observer() : this(null) {

        }
        public Observer(CarSubject? car) {
            this._car = car;
        }
    }
}
