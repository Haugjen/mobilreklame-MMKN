using MobilReklame.FilePersistancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilReklame
{
    public class CustomerCatalog : CatalogBase<Customer, Customer, int>
    {
        
        private static CustomerCatalog _customerCatalog;
        private FileSource<Customer, int> _dataSource;

        private CustomerCatalog(IFactory<Customer, Customer> factory) : base(factory)
        {
            _dataSource = new FileSource<Customer, int>(new FileStringPersistence(), new JSONConverter<Customer>());
        }
        
        public static CustomerCatalog Instance
        {
            get
            {
                if (_customerCatalog != null)
                {
                    return _customerCatalog;
                }
                _customerCatalog = new CustomerCatalog(new Factories.TrivialFactory<Customer>());
                return _customerCatalog;
            }
        }
        

        public override int NextKey()
        {
            int nextKey = Data.Keys.Count == 0 ? 1 : (int)Data.Keys.Max() + 1;
            return nextKey;
        }
    }
}
