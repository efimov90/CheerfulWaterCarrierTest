using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheerfulWaterCarrier.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        private readonly EmployeesListViewModel _employeesListViewModel;
        private readonly OrdersListViewModel _ordersListViewModel;
        private readonly SubdivisionsListViewModel _subdivisionsListViewModel;

        public ShellViewModel(EmployeesListViewModel employeesListViewModel, OrdersListViewModel ordersListViewModel, SubdivisionsListViewModel subdivisionsListViewModel)
        {
            _employeesListViewModel = employeesListViewModel;
            _ordersListViewModel = ordersListViewModel;
            _subdivisionsListViewModel = subdivisionsListViewModel;
        }

        public void LoadEmployeesList()
        {
            ActivateItem(_employeesListViewModel);
        }

        public void LoadOrdersList()
        {
            ActivateItem(_ordersListViewModel);
        }

        public void LoadSubdivisionsList()
        {
            ActivateItem(_subdivisionsListViewModel);
        }
    }
}
