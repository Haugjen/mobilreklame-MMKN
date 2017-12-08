using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilReklame.Order
{
    class Customer : IKey<string>
    {
        private string _customerName;
        private string _phoneNumber;
        private string _cvrNumber;
        private string _email;
        private string _contactName;
        private string _contactPhoneNumber;
        private string _contactEmail;
        private string _notes;

        public string Key
        {
            get => _cvrNumber;
            set => _cvrNumber = value;  //github not getting this?
        }

        // to do: more instance fields?
        // useless comment
        // useless comment 2

        // to do: make full constructor

        // to do: properties

        //to do: methods
    }


}
