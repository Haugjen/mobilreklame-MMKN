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
            Customer customer = new Customer();
            customer.CustomerName = obj.CustomerName;
            customer.PhoneNumber = obj.PhoneNumber;
            customer.CvrNumber = obj.CvrNumber;
            customer.Email = obj.Email;
            customer.ContactName = obj.ContactName;
            customer.ContactPhoneNumber = obj.ContactPhoneNumber;
            customer.ContactEmail = obj.ContactEmail;
            customer.Notes = obj.Notes;

            return customer;
        }
    }
}
