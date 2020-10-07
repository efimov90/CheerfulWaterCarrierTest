using CheerfulWaterCarrier.Models;
using System.Collections.Generic;

namespace CheerfulWaterCarrier.DataAccess
{
    public interface IEmployeeData
    {
        List<EmployeeModel> GetEmployees();
        void InsertEmployee(EmployeeModel item);
        void UpdateEmployee(EmployeeModel item);
    }
}