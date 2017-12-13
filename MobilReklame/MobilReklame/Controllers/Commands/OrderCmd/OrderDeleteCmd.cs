using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilReklame
{
    class OrderDeleteCmd : DeleteCommandBase<OrderTDTO, Order, int>
    {
        public OrderDeleteCmd(CatalogBase<OrderTDTO, Order, int> catalog, MasterDetailsViewModelBase<OrderTDTO, Order, int> viewModel) : base(catalog, viewModel)
        {
        }
    }
}
