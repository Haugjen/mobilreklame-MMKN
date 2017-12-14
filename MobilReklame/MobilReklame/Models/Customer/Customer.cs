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
        private int _phoneNumber;
        private int _cvrNumber;
        private string _email;
        private string _contactName;
        private int _contactPhoneNumber;
        private string _contactEmail;
        private string _notes;
        private int _customerNumber;    //used as key
        #endregion

        #region Constructor
        public Customer()
        {

            // former parameters string customerName, int phoneNumber, int cvrNumber, string email, string contactName,
            // int contactPhoneNumber, string contactEmail, string notes, int customerNumber; 

            //_customerName = customerName;
            //_phoneNumber = phoneNumber;
            //_cvrNumber = cvrNumber;
            //_email = email;
            //_contactName = contactName;
            //_contactPhoneNumber = contactPhoneNumber;
            //_contactEmail = contactEmail;
            //_notes = notes;
            //_customerNumber = customerNumber;
        }
        #endregion 

        #region Properties
        public string CustomerName { get => _customerName; set => value = _customerName; }

        public int PhoneNumber { get => _phoneNumber; set => value = _phoneNumber; }
        public int CvrNumber { get => _cvrNumber; set => value = _cvrNumber; }
        public string Email { get => _email; set => value = _email; }
        public string ContactName { get => _contactName; set => value = _contactName; }
        public int ContactPhoneNumber { get => _contactPhoneNumber; set => value = _contactPhoneNumber; }
        public string ContactEmail { get => _contactEmail; set => value = _contactEmail; }
        public string Notes { get => _notes; set => value = _notes; }
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
