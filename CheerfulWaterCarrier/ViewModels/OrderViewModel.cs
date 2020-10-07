using Caliburn.Micro;
using CheerfulWaterCarrier.DataAccess;
using CheerfulWaterCarrier.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheerfulWaterCarrier.ViewModels
{
    public class OrderViewModel : Screen
    {
        private readonly IOrderData _orderData;

        public OrderViewModel(IOrderData orderData)
        {
            _orderData = orderData;
        }

        private OrderModel _order = new OrderModel();

        public OrderModel Order
        {
            get 
            {
                return _order; 
            }
            set
            {
                _order = value;
                NotifyOfPropertyChange(() => Order);
            }
        }


        public void Save()
        {
            if (null != Order.OrderId)
            {
                _orderData.UpdateOrder(Order);
            }
            else
            {
                _orderData.InsertOrder(Order);
            }

            TryClose();
        }
    }
}
