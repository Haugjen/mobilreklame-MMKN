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
            Order order = new Order();
            order.StartupDate = obj.StartupDate;
            order.DeadlineDate = obj.DeadlineDate;
            order.WorkDescription = obj.WorkDescription;
            order.OrderMaterials = obj.OrderMaterials;
            order.OrderCustomer = obj.OrderCustomer;
            return order;
        }
    }
}
