using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilReklame
{
    public class OrderCatalog : CatalogBase<Order, Order, int>
    {
        public OrderCatalog(IFactory<Order, Order> factory) : base(factory)
        {
        }

        public override int NextKey()
        {
            int nextKey = (int)Data.Keys.Max() + 1;
            return nextKey;
        }

    }
}
