using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilReklame.Order
{
    class Customer : IKey<int>
    {
        #region Instance field
        private string _customerName;
        private int _phoneNumber;
        private int _cvrNumber;
        private string _email;
        private string _contactName;
        private int _contactPhoneNumber;
        private string _contactEmail;
        private string _notes;
        private int _customerNumber;
        #endregion

        #region Constructor
        public Customer(string customerName, int phoneNumber, int cvrNumber, string email, string contactName,
            int contactPhoneNumber, string contactEmail, string notes, int customerNumber)
        {
            _customerName = customerName;
            _phoneNumber = phoneNumber;
            _cvrNumber = cvrNumber;
            _email = email;
            _contactName = contactName;
            _contactPhoneNumber = contactPhoneNumber;
            _contactEmail = contactEmail;
            _notes = notes;
            _customerNumber = customerNumber;
        }
        #endregion

        #region Properties
        public string CustomerName => _customerName;
        public int PhoneNumber => _phoneNumber;
        public int CvrNumber => _cvrNumber;
        public string Email => _email;
        public string ContactName => _contactName;
        public int ContactPhoneNumber => _contactPhoneNumber;
        public string ContactEmail => _contactEmail;
        public string Notes => _notes;
        #endregion

        #region Methods



        #endregion

        public int Key
        {
            get => _customerNumber;
            set => _customerNumber = value;  //github not getting this?
        }

        // to do: more instance fields?
        // useless comment
        // useless comment 2

        // to do: make full constructor

        // to do: properties

        //to do: methods
    }


}
