using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilReklame
{
    class OrderMDVM : MasterDetailsViewModelBase<OrderTDTO, Order, int>
    {
        protected OrderMDVM(CatalogBase<OrderTDTO, Order, int> catalog, ViewModelFactoryBase<OrderTDTO, Order, int> factory) : base(catalog, factory)
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
