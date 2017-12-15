using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilReklame;
using MobilReklame.Controllers.ViewModels.CustomerVM;
using MobilReklame.Controllers.ViewModels.OrderVM;
using System.Windows.Input;

namespace MobilReklame.Controllers.ViewModels
{
    public class CombinedMDVM
    {

        public CombinedMDVM()
        {
            CustomerMasterDetailsViewModel = new CustomerMDVM();
            OrderMasterDtailsViewModel = new OrderMDVM();
        }

        public CustomerMDVM CustomerMasterDetailsViewModel { get; }
        public OrderMDVM OrderMasterDtailsViewModel { get; }

        

    }
}
