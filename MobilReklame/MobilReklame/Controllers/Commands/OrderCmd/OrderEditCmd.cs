using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilReklame
{
    class OrderEditCmd : EditCommandBase<OrderTDTO, Order, int>
    {
        public OrderEditCmd(CatalogBase<OrderTDTO, Order, int> catalog, MasterDetailsViewModelBase<OrderTDTO, Order, int> viewModel) : base(catalog, viewModel)
        {
        }
    }
}
