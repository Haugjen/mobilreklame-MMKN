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

        public string CustomerName
        {
            get => DataPackage.CustomerName;
            set => DataPackage.CustomerName = value;
        }
        public int PhoneNumber { get => DataPackage.PhoneNumber; set => DataPackage.PhoneNumber = value; }
        public int CvrNumber { get => DataPackage.CvrNumber; set => DataPackage.CvrNumber = value; }
        public string Email { get => DataPackage.Email; set => DataPackage.Email = value; }
        public string ContactName { get => DataPackage.ContactName; set => DataPackage.ContactName = value; }
        public int ContactPhoneNumber { get => DataPackage.ContactPhoneNumber; set => DataPackage.ContactPhoneNumber = value; }
        public string ContactEmail { get => DataPackage.ContactEmail; set => DataPackage.ContactEmail = value; }
        public string Notes { get => DataPackage.Notes; set => DataPackage.Notes = value; }
        public int CustomerNumber { get => DataPackage.Key; }
        public int Key { get => CustomerNumber; }



    }
}
