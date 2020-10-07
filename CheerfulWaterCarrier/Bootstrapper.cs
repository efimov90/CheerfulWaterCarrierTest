using Caliburn.Micro;
using CheerfulWaterCarrier.DataAccess;
using CheerfulWaterCarrier.Internal.DataAccess;
using CheerfulWaterCarrier.ViewModels;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CheerfulWaterCarrier
{
    public class Bootstrapper : BootstrapperBase
    {
        private SimpleContainer _container = new SimpleContainer();

        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
        }

        protected override void Configure()
        {
            _container.Singleton<IWindowManager, WindowManager>()
                      .Singleton<ISqlDataAccess, SqlDataAccess>()
                      //.Singleton<IConfiguration, ConfigurationRoot>()
                      .Singleton<IEmployeeData, EmployeeData>()
                      .Singleton<IOrderData, OrderData>()
                      .Singleton<ISubdivisionData, SubdivisionData>();

            _container.PerRequest<ShellViewModel>()
                      .PerRequest<EmployeesListViewModel>()
                      .PerRequest<OrdersListViewModel>()
                      .PerRequest<SubdivisionsListViewModel>()
                      .PerRequest<EmployeeViewModel>()
                      .PerRequest<OrderViewModel>()
                      .PerRequest<SubdivisionViewModel>();
        }

        protected override object GetInstance(Type service, string key)
        {
            return _container.GetInstance(service, key);
        }

        protected override IEnumerable<object> GetAllInstances(Type serviceType)
        {
            return _container.GetAllInstances(serviceType);
        }

        protected override void BuildUp(object instance)
        {
            _container.BuildUp(instance);
        }
    }
}
