using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilReklame
{
    class CustomerDeleteCmd : DeleteCommandBase<CustomerTDTO, Customer, int>
    {
        public CustomerDeleteCmd(CatalogBase<CustomerTDTO, Customer, int> catalog, MasterDetailsViewModelBase<CustomerTDTO, Customer, int> viewModel) : base(catalog, viewModel)
        {
        }
    }
}
