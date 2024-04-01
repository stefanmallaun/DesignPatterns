using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern3.Models
{
    internal class Observer : ISubject
    {
        public CarSubject? Value;


        public void Update()
        {
            if(Value != null)
            {
                Console.WriteLine(Value.Name + " " + Value.Value);
                if (Value.Value > 100) { 
                Console.WriteLine("ALARMMMMMMM");
                }
            }
        }
        public Observer(): this(null){ }

        public Observer(CarSubject? a)
        {
            this.Value = a;
        }
    }
}
