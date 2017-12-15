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
        //public enum OrderStatus { Request, Offer, AktiveStatus, Finished, Invoiced, AktiveRed1, ActiveRed2, ActiveYellow, ActiveGreen }
        #endregion
        


        #region Instance field
        private int _orderNumber;
        private string _startupDate;
        private string _deadlineDate;
        private string _workDescription;
        private OrderMaterials _orderMaterials;
        private Customer _orderCustomer;
        private string _orderStatus;
        private List<string> _orderStatusList;
        #endregion

        #region Enumeration Instance field
       // private OrderStatus _orderStatus;
        #endregion

        #region Constructor
        public Order()
        {
            _orderStatusList = new List<string>();
            _orderStatusList.Add("Ny Oprettede");
            _orderStatusList.Add("Tilbud");
            _orderStatusList.Add("Aktiv");
            _orderStatusList.Add("Afsluttet");
        }
        #endregion

        #region Properties
        public int OrderNumber { get => _orderNumber; set => _orderNumber = value; }

        public string StartupDate { get => _startupDate; set => _startupDate = value; }
        public string DeadlineDate { get => _deadlineDate; set => _deadlineDate = value; }
        public string WorkDescription { get => _workDescription; set => _workDescription = value; }
        public OrderMaterials OrderMaterials { get => _orderMaterials; set =>_orderMaterials = value; }
        public Customer OrderCustomer { get => _orderCustomer; set => _orderCustomer = value; }
        public List<string> OrderStatusList { get => _orderStatusList; }
        public string OrderStatus { get => _orderStatus ; set => _orderStatus = value; }
        



        public int Key { get => _orderNumber; set =>_orderNumber = value;}
        #endregion

        #region Methods



        #endregion

        // to do properties here

        // to do methods here

    }
}
