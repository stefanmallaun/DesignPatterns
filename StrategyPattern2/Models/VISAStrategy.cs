using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern2.Models
{
    internal class VISAStrategy : iStrategy
    {
        public bool Pay(decimal amount)
        {
            Console.WriteLine("Wurde mit VISA bezahlt: " + amount);
            return true;
        }
    }
}
