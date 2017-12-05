using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilReklame.Models;

namespace MobilReklame.Order
{
    class Order
    {
        #region Instance field
        private string _orderNumber;
        private string _startupDate;
        private string _deadlineDate;
        private string _workDescription;
        private OrderMaterials _orderMaterials;
        private Customer _orderCustomer;
        #endregion

        #region Constructor

        public Order(string orderNumber, string startupDate, string deadlineDate, string workDescription, OrderMaterials orderMaterials, Customer orderCustomer)
        {
            _orderNumber = orderNumber;
            _startupDate = startupDate;
            _deadlineDate = deadlineDate;
            _workDescription = workDescription;
            _orderMaterials = orderMaterials;
            _orderCustomer = orderCustomer;
        }


        #endregion

        #region Properties
        public string OrderNumber => _orderNumber;
        public string StartupDate => _startupDate;
        public int DeadlineDate => _deadlineDate;
        public string WorkDescription => _workDescription;
        public string OrderMaterials => _orderMaterials;
        public string OrderCustomer => _orderCustomer;


        #endregion

        #region Methods



        #endregion

        // to do properties here

        // to do methods here

    }
}
