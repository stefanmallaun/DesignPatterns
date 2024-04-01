using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern3.Models
{
    internal class CarSubject : Subject
    {

        public string Name { get; set; }
        private int zähler;

        public int Value
        {
            get{ return zähler; }

            set{
                
                    this.zähler = value;
                    this.Notify();
                
            }
        }
        public CarSubject() : this("", 0) { }

        public CarSubject(string Name, int value)
        {
            this.Name = Name;
            this.Value = value;
        }

        public override string ToString()
        {
            return this.Name + ": " + this.Value;
        }
    }
}
