using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilReklame
{
    class CustomerEditCmd : EditCommandBase<CustomerTDTO, Customer, int>
    {
        public CustomerEditCmd(CatalogBase<CustomerTDTO, Customer, int> catalog, MasterDetailsViewModelBase<CustomerTDTO, Customer, int> viewModel) : base(catalog, viewModel)
        {
        }
    }
}
