using Caliburn.Micro;
using CheerfulWaterCarrier.DataAccess;
using CheerfulWaterCarrier.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheerfulWaterCarrier.ViewModels
{
    public class EmployeesListViewModel : Screen
    {
        private readonly IWindowManager _windowManager;
        private readonly IEmployeeData _employeeData;

        public EmployeesListViewModel(IWindowManager windowManager, IEmployeeData employeeData)
        {
            _windowManager = windowManager;
            _employeeData = employeeData;

            LoadEmployees();
        }

        private BindableCollection<EmployeeModel> employees = new BindableCollection<EmployeeModel>();

        public BindableCollection<EmployeeModel> Employees
        {
            get
            {
                return employees;
            }
            set
            {
                employees = value;
                NotifyOfPropertyChange(() => Employees);
            }
        }

        private EmployeeModel selectedEmployee;

        public EmployeeModel SelectedEmployee
        {
            get 
            {
                return selectedEmployee; 
            }
            set 
            {
                selectedEmployee = value;
                NotifyOfPropertyChange(() => SelectedEmployee);
                NotifyOfPropertyChange(() => CanModify);
            }
        }

        public bool CanModify
        {
            get
            {
                bool output = false;

                if (null != SelectedEmployee && Employees.IndexOf(SelectedEmployee) > -1)
                {
                    output = true;
                }

                return output;
            }
        }

        public void Modify()
        {
            var employeeVM = new EmployeeViewModel(_employeeData);

            employeeVM.Employee = SelectedEmployee;

            _windowManager.ShowDialog(employeeVM);
        }

        private void LoadEmployees()
        {
            var employees = _employeeData.GetEmployees();

            foreach (var employee in employees)
            {
                Employees.Add(employee);
            }
        }

        public void Add()
        {
            _windowManager.ShowDialog(new EmployeeViewModel(_employeeData));
        }

        public void BtnRefresh()
        {
            employees.Clear();

            LoadEmployees();
        }
    }
}
