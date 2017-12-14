using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilReklame;
using MobilReklame.Controllers.ViewModels.VMFactories;
namespace MobilReklame.Controllers.ViewModels.CustomerVM
{
    public class CustomerMDVM : MasterDetailsViewModelBase<Customer, Customer, int>
    {
        
        public CustomerMDVM() 
            : base(CustomerCatalog.Instance, new CustomerVMFactory())
        {
            
        }

        public string CustomerName { get => Obj.CustomerName; set => Obj.CustomerName = value; }
        public int PhoneNumber { get => Obj.PhoneNumber; set => Obj.PhoneNumber = value; }
        public int CvrNumber { get => Obj.CvrNumber; set => Obj.CvrNumber = value; }
        public string Email { get => Obj.Email; set => Obj.Email = value; }
        public string ContactName { get => Obj.ContactName; set => Obj.ContactName = value; }
        public int ContactPhoneNumber { get => Obj.ContactPhoneNumber; set => Obj.ContactPhoneNumber = value; }
        public string ContactEmail { get => Obj.ContactEmail; set => Obj.ContactEmail = value; }
        public string Notes { get => Obj.Notes; set => Obj.Notes = value; }
        public int CustomerNumber { get => Obj.Key; } //no setter!?
        public int Key { get => CustomerNumber; }


    }
}
