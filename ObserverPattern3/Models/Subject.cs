using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern3.Models
{
    internal class Subject
    {
        private List<ISubject> _observers = new List<ISubject>();

        public void Register(ISubject observer)
        {
            if(observer != null)
            {
                _observers.Add(observer);
            }

        }
        public void Unregister(ISubject observer)
        {
            if(observer != null)
            {
                _observers.Remove(observer);
            }

        }
        public void Notify()
        {
            if(_observers.Count > 0)
            {
                foreach(ISubject o in _observers)
                {
                    o.Update();
                }
            }
        }
    }
}
