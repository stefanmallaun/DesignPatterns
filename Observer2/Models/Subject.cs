using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer2.Models
{
    internal class Subject {

        private List<iMyObserver> _observers = new List<iMyObserver>();

        public void Register(iMyObserver observer) {
            if (observer != null) {
                this._observers.Add(observer);
            }
        }
        public bool Unregister(iMyObserver observer) {
            if (observer != null) {
                return this._observers.Remove(observer);
            }
            return false;
        }
        public void Notify() {
            if (this._observers.Count > 0) {

                foreach (iMyObserver o in this._observers) {
                    o.Update();

                }
            }
        }
    }
}
