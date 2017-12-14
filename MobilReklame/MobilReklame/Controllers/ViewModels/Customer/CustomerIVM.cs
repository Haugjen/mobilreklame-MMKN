using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilReklame
{
    public class CustomerIVM : ItemViewModelBase<Customer, int>
    {
        protected CustomerIVM(Customer obj) : base(obj)
        {

        }
        
        public string CustomerName { get => Obj.CustomerName; set => Obj.CustomerName = value; }
        public int PhoneNumber { get => Obj.PhoneNumber; set => Obj.PhoneNumber = value; }
        public int CvrNumber { get => Obj.CvrNumber; set => Obj.CvrNumber = value; }
        public string Email { get => Obj.Email; set => Obj.Email = value; }
        public int CustomerNumber { get => Obj.Key; set => Obj.Key = value; } //no setter!?
        public int Key { get => CustomerNumber; }
    }
}
