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
    public class OrdersListViewModel : Screen
    {
        private readonly IWindowManager _windowManager;
        private readonly IOrderData _orderData;

        public OrdersListViewModel(IWindowManager windowManager, IOrderData orderData)
        {
            _windowManager = windowManager;
            _orderData = orderData;

            LoadOrders();
        }

        private BindableCollection<OrderModel> orders = new BindableCollection<OrderModel>();

        public BindableCollection<OrderModel> Orders
        {
            get 
            {
                return orders; 
            }
            set 
            {
                orders = value; 
            }
        }

        private OrderModel selectedOrder;

        public OrderModel SelectedOrder
        {
            get 
            { 
                return selectedOrder; 
            }
            set 
            { 
                selectedOrder = value;
                NotifyOfPropertyChange(() => SelectedOrder);
                NotifyOfPropertyChange(() => CanModify);
            }
        }

        public bool CanModify
        {
            get
            {
                bool output = false;

                if (null != SelectedOrder && Orders.IndexOf(SelectedOrder) > -1)
                {
                    output = true;
                }

                return output;
            }
        }

        public void Modify()
        {
            var orderVM = new OrderViewModel(_orderData);

            orderVM.Order = SelectedOrder;

            _windowManager.ShowDialog(orderVM);
        }

        public void BtnRefresh()
        {
            Orders.Clear();

            LoadOrders();
        }

        private void LoadOrders()
        {
            var orders = _orderData.GetOrders();

            foreach (var order in orders)
            {
                Orders.Add(order);
            }
        }

        public void Add()
        {
            _windowManager.ShowDialog(new OrderViewModel(_orderData));
        }
    }
}
