using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilReklame.Controllers.ViewModels.VMFactories;
using MobilReklame;
using MobilReklame.Controllers.Commands.OrderCmd;

namespace MobilReklame.Controllers.ViewModels.OrderVM
{
    public class OrderMDVM : MasterDetailsViewModelBase<Order, Order, int>
    {
        // private OrderSaveCmd

        public OrderMDVM()
            :base (OrderCatalog.Instance, new OrderVMFactory())
        {

        }

        public int OrderNumber { get => Obj.OrderNumber; set => Obj.OrderNumber = value; }
        public string StartupDate { get => Obj.StartupDate; set => Obj.StartupDate = value; }
        public string DeadlineDate { get => Obj.DeadlineDate; set => Obj.DeadlineDate = value; }
        public string WorkDescription { get => Obj.WorkDescription; set => Obj.WorkDescription = value; }
        public OrderMaterials OrderMaterials { get => Obj.OrderMaterials; set => Obj.OrderMaterials = value; }
        public Customer OrderCustomer { get => Obj.OrderCustomer; set => Obj.OrderCustomer = value; }
        public int Key { get; set; }
    }
}
