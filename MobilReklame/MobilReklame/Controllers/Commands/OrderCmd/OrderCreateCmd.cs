using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilReklame
{
    class OrderCreateCmd : CreateCommandBase<OrderTDTO, Order, int>
    {
        public OrderCreateCmd(CatalogBase<OrderTDTO, Order, int> catalog, MasterDetailsViewModelBase<OrderTDTO, Order, int> viewModel) : base(catalog, viewModel)
        {
        }
    }
}
