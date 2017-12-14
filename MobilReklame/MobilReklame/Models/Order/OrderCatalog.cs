using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilReklame
{
    public class OrderCatalog : CatalogBase<Order, Order, int>
    {
        private OrderCatalog _orderCatalog;
        private OrderCatalog(IFactory<Order, Order> factory) : base(factory)
        {
        }

        public OrderCatalog instance
        {
            get
            {
                if (_orderCatalog != null)
                {
                    return _orderCatalog;
                }
                _orderCatalog = new OrderCatalog(new OrderFactory());
                return _orderCatalog;
            }
        }
     
        public override int NextKey()
        {
            int nextKey = (int)Data.Keys.Max() + 1;
            return nextKey;
        }


        OrderCatalog test = new OrderCatalog(new OrderFactory());
    }
}
