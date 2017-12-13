using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilReklame
{
    public class CustomerCatalog : CatalogBase<Customer, Customer, int>
    {
        public CustomerCatalog(IFactory<Customer, Customer> factory) : base(factory)
        {
        }

        public override int NextKey()
        {
            int nextKey = (int)Data.Keys.Max() + 1;
            return nextKey;
        }
    }
}
