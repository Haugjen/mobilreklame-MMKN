using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// using MobilReklame.Models;

namespace MobilReklame
{
    public class Order : IKey<int>
    {
        #region Enumeration
        public enum OrderStatus { Request, Offer, AktiveStatus, Finished, Invoiced, AktiveRed1, ActiveRed2, ActiveYellow, ActiveGreen }
        #endregion

        #region Instance field
        private int _orderNumber;
        private string _startupDate;
        private string _deadlineDate;
        private string _workDescription;
        private OrderMaterials _orderMaterials;
        private Customer _orderCustomer;
        #endregion

        #region Enumeration Instance field
        private OrderStatus _orderStatus;
        #endregion

        #region Constructor
        public Order()
        {
            // former parameters :: string startupDate, string deadlineDate, string workDescription, OrderMaterials orderMaterials, Customer orderCustomer
            //_startupDate = startupDate;
            //_deadlineDate = deadlineDate;
            //_workDescription = workDescription;
            //_orderMaterials = orderMaterials;
            //_orderCustomer = orderCustomer;
        }
        #endregion

        #region Enumeration Constructor
        public Order(OrderStatus orderStatus)
        {
            _orderStatus = orderStatus;
        }
        #endregion

        #region Properties
        public int OrderNumber { get => _orderNumber; set => value = _orderNumber; }

        public string StartupDate { get => _startupDate; set => value = _startupDate; }
        public string DeadlineDate { get => _deadlineDate; set => value = _deadlineDate; }
        public string WorkDescription { get => _workDescription; set => value = _workDescription; }
        public OrderMaterials OrderMaterials { get => _orderMaterials; set => value = _orderMaterials; }
        public Customer OrderCustomer { get => _orderCustomer; set => value = _orderCustomer; }
        #endregion

        #region Enumeration Properties
        public string Description
        {
            get
            {
                return $"{_orderStatus}";
            }
        }

        public int Key { get => _orderNumber; set => value = _orderNumber;}
        #endregion

        #region Methods



        #endregion

        // to do properties here

        // to do methods here

    }
}
