using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilReklame
{
    public class CustomerCatalog : CatalogBase<Customer, Customer, int>
    {
        protected CustomerCatalog(IFactory<Customer, Customer> factory) : base(factory)
        {
        }
    }
}
