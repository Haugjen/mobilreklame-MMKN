﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilReklame
{
    public class OrderCatalog : CatalogBase<Order, Order, int>
    {
        protected OrderCatalog(IFactory<Order, Order> factory) : base(factory)
        {
        }
    }
}
