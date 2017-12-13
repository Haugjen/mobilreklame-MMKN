using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilReklame.Controllers.ViewModels.VMFactories;
using MobilReklame;


namespace MobilReklame.Controllers.ViewModels.OrderVM
{
    public class OrderMDVM : MasterDetailsViewModelBase<Order, Order, int>
    {
        public OrderMDVM()
            :base (new OrderCatalog(new Factories.TrivialFactory<Order>()), new OrderVMFactory())





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
