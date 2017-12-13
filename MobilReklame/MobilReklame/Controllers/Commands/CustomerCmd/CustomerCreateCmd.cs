using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilReklame
{
    class CustomerCreateCmd : CreateCommandBase<CustomerTDTO, Customer, int>
    {
        public CustomerCreateCmd(CatalogBase<CustomerTDTO, Customer, int> catalog, MasterDetailsViewModelBase<CustomerTDTO, Customer, int> viewModel) : base(catalog, viewModel)
        {
        }
    }
}
