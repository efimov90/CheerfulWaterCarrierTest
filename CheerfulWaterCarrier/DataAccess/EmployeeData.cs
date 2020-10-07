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
    public class EmployeeData : IEmployeeData
    {
        private readonly IConfiguration _config;
        private readonly ISqlDataAccess _sql;

        public EmployeeData(IConfiguration config, ISqlDataAccess sql)
        {
            _config = config;
            _sql = sql;
        }

        public List<EmployeeModel> GetEmployees()
        {
            var output = _sql.LoadData<EmployeeModel, dynamic>("dbo.spEmployee_GetAll", new { }, "CheerfulWaterCarrierDB");

            return output;
        }

        public void InsertEmployee(EmployeeModel item)
        {
            _sql.SaveData("dbo.spEmployee_Insert", item, "CheerfulWaterCarrierDB");
        }

        public void UpdateEmployee(EmployeeModel item)
        {
            _sql.SaveData("dbo.spEmployee_Update", item, "CheerfulWaterCarrierDB");
        }
    }
}
