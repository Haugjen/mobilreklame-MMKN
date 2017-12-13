using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilReklame
{
    public class OrderFactory : IFactory<Order, OrderTDTO>
    {
        public Order Convert(OrderTDTO obj)
        {
            throw new NotImplementedException();
        }
    }
}
