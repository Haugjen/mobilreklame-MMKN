using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilReklame;

namespace MobilReklame.Controllers.ViewModels.VMFactories
{
    class OrderVMFactory : ViewModelFactoryBase<Order, Order, int>
    {
        public override ItemViewModelBase<Order, int> CreateItemViewModel(Order obj)
        {
            return new OrderIVM(obj);
        }
    }
}
