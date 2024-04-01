using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern2.Models
{
    internal class Item
    {
        private String _name;

        public Item(string v)
        {
        }

        public String Name{

            get { return _name; }
            set
            {
                if (Name != null)
                {
                    this._name = Name;
                }
            }
            }
    }
}
