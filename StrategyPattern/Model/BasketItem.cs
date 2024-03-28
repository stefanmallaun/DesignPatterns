using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.Models
{
    internal class BasketItem
    {
        public Article Article { get; set; }    
        public int Amount { get; set; } 
    }
}
