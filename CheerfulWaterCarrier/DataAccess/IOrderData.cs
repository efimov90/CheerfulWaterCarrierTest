using CheerfulWaterCarrier.Models;
using System.Collections.Generic;

namespace CheerfulWaterCarrier.DataAccess
{
    public interface IOrderData
    {
        List<OrderModel> GetOrders();
        void InsertOrder(OrderModel item);
        void UpdateOrder(OrderModel item);
    }
}