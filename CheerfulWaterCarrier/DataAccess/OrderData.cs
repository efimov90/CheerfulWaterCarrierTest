using CheerfulWaterCarrier.Internal.DataAccess;
using CheerfulWaterCarrier.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheerfulWaterCarrier.DataAccess
{
    public class OrderData : IOrderData
    {
        private readonly IConfiguration _config;
        private readonly ISqlDataAccess _sql;

        public OrderData(IConfiguration config, ISqlDataAccess sql)
        {
            _config = config;
            _sql = sql;
        }

        public List<OrderModel> GetOrders()
        {
            var output = _sql.LoadData<OrderModel, dynamic>("dbo.spOrder_GetAll", new { }, "CheerfulWaterCarrierDB");

            return output;
        }

        public void InsertOrder(OrderModel item)
        {
            _sql.SaveData("dbo.spOrder_Insert", item, "CheerfulWaterCarrierDB");
        }

        public void UpdateOrder(OrderModel item)
        {
            _sql.SaveData("dbo.spOrder_Update", item, "CheerfulWaterCarrierDB");
        }
    }
}
