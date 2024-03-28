using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.Models
{
    internal interface iPayment
    {
        bool Pay(decimal value);

    }
}
