using MobilReklame.Controllers.ViewModels.VMFactories;

namespace MobilReklame.Controllers.ViewModels.OrderVM
{
    public class OrderMDVM : MasterDetailsViewModelBase<Order, Order, int>
    {

        public OrderMDVM()
            :base (OrderCatalog.Instance, new OrderVMFactory())
        {

        }

        public int OrderNumber { get => DataPackage.OrderNumber; set => DataPackage.OrderNumber = value; }
        public string StartupDate { get => DataPackage.StartupDate; set => DataPackage.StartupDate = value; }
        public string DeadlineDate { get => DataPackage.DeadlineDate; set => DataPackage.DeadlineDate = value; }
        public string WorkDescription { get => DataPackage.WorkDescription; set => DataPackage.WorkDescription = value; }
        public OrderMaterials OrderMaterials { get => DataPackage.OrderMaterials; set => DataPackage.OrderMaterials = value; }
        public Customer OrderCustomer { get => DataPackage.OrderCustomer; set => DataPackage.OrderCustomer = value; }
        public string OrderDescription
        {
            get => DataPackage.Description.ToString();
            
        }
        
        public int Key { get; set; }
    }
}
