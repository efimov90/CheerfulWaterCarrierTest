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
    public class EmployeeViewModel : Screen
    {
        private readonly IEmployeeData _employeeData;

        public EmployeeViewModel(IEmployeeData employeeData)
        {
            _employeeData = employeeData;
        }

        private EmployeeModel employee = new EmployeeModel() { BirthDate = DateTime.Now };

        public EmployeeModel Employee
        {
            get
            {
                return employee; 
            }
            set
            {
                employee = value;
                NotifyOfPropertyChange(() => Employee);
            }
        }

        public void Save()
        {
            if (null != Employee.EmployeeId)
            {
                _employeeData.UpdateEmployee(Employee);
            }
            else
            {
                _employeeData.InsertEmployee(Employee);
            }

            TryClose();
        }
    }
}
