using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilReklame.Customer
{
    class Customer
    {
        #region Instance field
        private string _customerName;
        private string _phoneNumber;
        private int _cvrNumber;
        private string _email;
        private string _contactName;
        private string _contactPhoneNumber;
        private string _contactEmail;
        private string _notes;
        #endregion

        #region Constructor
        public Customer(string customerName, string phoneNumber, int cvrNumber, string email, string contactName,
            string contactPhoneNumber, string contactEmail, string notes)
        {
            _customerName = customerName;
            _phoneNumber = phoneNumber;
            _cvrNumber = cvrNumber;
            _email = email;
            _contactName = contactName;
            _contactPhoneNumber = contactPhoneNumber;
            _contactEmail = contactEmail;
            _notes = notes;
        }
        #endregion

        #region Properties
        public string CustomerName => _customerName;
        public string PhoneNumber => _phoneNumber;
        public int CvrNumber => _cvrNumber;
        public string Email => _email;
        public string ContactName => _contactName;
        public string ContactPhoneNumber => _contactPhoneNumber;
        public string ContactEmail => _contactEmail;
        public string Notes => _notes;
        #endregion

        #region Methods



        #endregion

        // to do: more instance fields?
        // useless comment
        // useless comment 2

        // to do: make full constructor

        // to do: properties

        //to do: methods
    }


}
