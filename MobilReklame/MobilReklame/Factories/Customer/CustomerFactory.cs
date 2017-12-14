using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilReklame
{
    public class CustomerFactory : IFactory<Customer, Customer>
    {
        public Customer Convert(Customer obj)
        {
            Customer customer = new Customer
            {
                CustomerName = obj.CustomerName,
                PhoneNumber = obj.PhoneNumber,
                CvrNumber = obj.CvrNumber,
                Email = obj.Email,
                ContactName = obj.ContactName,
                ContactPhoneNumber = obj.ContactPhoneNumber,
                ContactEmail = obj.ContactEmail,
                Notes = obj.Notes
            };

            return customer;
        }
    }
}
