using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilReklame
{
    class OrderCreateCmd : CreateCommandBase<CustomerTDTO, Customer, int>
    {
        public OrderCreateCmd(CatalogBase<CustomerTDTO, Customer, int> catalog, MasterDetailsViewModelBase<CustomerTDTO, Customer, int> viewModel) : base(catalog, viewModel)
        {
        }
    }
}
