using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilReklame
{
    public class CustomerCatalog : CatalogBase<Customer, Customer, int>
    {
        //public CustomerCatalog(IFactory<Customer, Customer> factory) : base(factory)
        //{
        //}
        private static CustomerCatalog _customerCatalog;
        private CustomerCatalog(IFactory<Customer, Customer> factory) : base(factory)
        {

        }

        public static CustomerCatalog Instance
        {
            get
            {
                if (_customerCatalog != null)
                {
                    return _customerCatalog;
                }
                _customerCatalog = new CustomerCatalog(new CustomerFactory());
                return _customerCatalog;
            }
        }

        public override int NextKey()
        {
            int nextKey = (int)Data.Keys.Max() + 1;
            return nextKey;
        }
    }
}
