using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilReklame
{
    public class OrderTDTO : IKey<int>
    {
        private int _orderNumber;
        private string _startupDate;
        private string _deadlineDate;
        private string _workDescription;
        private OrderMaterials _orderMaterials;
        private Customer _orderCustomer;

        
        public int OrderNumber { get => _orderNumber; set => _orderNumber = value; }
        public string StartupDate { get => _startupDate; set => _startupDate = value; }
        public string DeadlineDate { get => _deadlineDate; set => _deadlineDate = value; }
        public string WorkDescription { get => _workDescription; set => _workDescription = value; }
        public OrderMaterials OrderMaterials { get => _orderMaterials; set => _orderMaterials = value; }
        public Customer OrderCustomer { get => _orderCustomer; set => _orderCustomer = value; }
        public int Key { get; set; }

    }
}
