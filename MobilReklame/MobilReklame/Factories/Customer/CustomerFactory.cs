using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilReklame
{
    public class CustomerFactory : IFactory<Customer, CustomerTDTO>
    {
        public Customer Convert(CustomerTDTO obj)
        {
            throw new NotImplementedException();
        }
    }
}
