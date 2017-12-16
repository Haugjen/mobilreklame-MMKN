using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilReklame
{
    public class Customer : IKey<int>
    {
        #region Instance field
        private string _customerName;
        private string _phoneNumber;
        private string _cvrNumber;
        private string _email;
        private string _contactName;
        private string _contactPhoneNumber;
        private string _contactEmail;
        private string _notes;
        private int _customerNumber;    //used as key
        #endregion

        #region Constructor
        public Customer()
        {
        }
        #endregion 

        #region Properties
        public string CustomerName
        {
            get => _customerName; set => _customerName = value; }

        public string PhoneNumber { get => _phoneNumber; set => _phoneNumber = value; }
        public string CvrNumber { get => _cvrNumber; set => _cvrNumber = value; }
        public string Email { get => _email; set =>  _email = value; }
        public string ContactName { get => _contactName; set => _contactName = value; }
        public string ContactPhoneNumber { get => _contactPhoneNumber; set => _contactPhoneNumber = value; }
        public string ContactEmail { get => _contactEmail; set => _contactEmail = value; }
        public string Notes { get => _notes; set => _notes = value; }
        public int Key
        {
            get => _customerNumber;
            set => _customerNumber = value;
        }
        #endregion

        #region Methods



        #endregion


    }


}
