using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilReklame
{
    public class CustomerIVM : ItemViewModelBase<Customer, int>
    {
        protected CustomerIVM(Customer obj) : base(obj)
        {
        }
    }
}
