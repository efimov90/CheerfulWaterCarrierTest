using CheerfulWaterCarrier.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CheerfulWaterCarrier.Views
{
    /// <summary>
    /// Логика взаимодействия для EmployeeView.xaml
    /// </summary>
    public partial class EmployeeView : Window
    {
        public EmployeeView()
        {
            InitializeComponent();

            EmployeeSexComboBox.SelectedValuePath = "Key";
            EmployeeSexComboBox.DisplayMemberPath = "Value";

            EmployeeSexComboBox.Items.Add(new KeyValuePair<EmployeeModel.ESex, string>(EmployeeModel.ESex.Female, "Женский"));
            EmployeeSexComboBox.Items.Add(new KeyValuePair<EmployeeModel.ESex, string>(EmployeeModel.ESex.Male, "Мужской"));
        }
    }
}
