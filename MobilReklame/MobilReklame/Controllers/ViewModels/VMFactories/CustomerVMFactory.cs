using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilReklame;
using MobilReklame.Controllers.ViewModels.CustomerVM;

namespace MobilReklame.Controllers.ViewModels.VMFactories
{
    class CustomerVMFactory : ViewModelFactoryBase<Customer, Customer, int>
    {
        public override ItemViewModelBase<Customer, int> CreateItemViewModel(Customer obj)
        {
            return new CustomerIVM(obj);
        }
    }
}
