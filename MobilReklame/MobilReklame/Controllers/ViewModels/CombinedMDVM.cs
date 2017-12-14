using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilReklame;
using MobilReklame.Controllers.ViewModels.CustomerVM;
using MobilReklame.Controllers.ViewModels.OrderVM;


namespace MobilReklame.Controllers.ViewModels
{
    class CombinedMDVM
    {
        public CustomerMDVM customerMDVM = new CustomerMDVM();
        public OrderMDVM orderMDVM = new OrderMDVM();


    }
}
