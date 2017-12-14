using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilReklame
{
    class OrderIVM : ItemViewModelBase<Order, int>
    {
        public OrderIVM(Order obj) : base(obj)
        {

        }
        public int OrderNumber { get => Obj.OrderNumber; set => Obj.OrderNumber = value; }
        public string StartupDate { get => Obj.StartupDate; set => Obj.StartupDate = value; }
        public string DeadlineDate { get => Obj.DeadlineDate; set => Obj.DeadlineDate = value; }
        public string WorkDescription { get => Obj.WorkDescription; set => Obj.WorkDescription = value; }
        public OrderMaterials OrderMaterials { get => Obj.OrderMaterials; set => Obj.OrderMaterials = value; }
        public Customer OrderCustomer { get => Obj.OrderCustomer; set => Obj.OrderCustomer = value; } // no setter!?
        public int Key { get; set; }
    }
}
