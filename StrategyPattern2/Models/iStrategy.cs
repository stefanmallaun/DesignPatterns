﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern2.Models
{
    internal interface iStrategy
    {
        public bool Pay(decimal amount);
    }
}
