﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilReklame
{
    public class OrderTDTO : IKey<int>
    {
        public int Key { get; set; }
    }
}
