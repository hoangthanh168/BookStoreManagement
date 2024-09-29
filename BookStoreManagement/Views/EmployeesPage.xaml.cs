using BookStoreManagement.ViewModels;
using System.Windows.Controls;

namespace BookStoreManagement.Views
{
    /// <summary>
    /// Interaction logic for EmployeesPage.xaml
    /// </summary>
    public partial class EmployeesPage : UserControl
    {
        public EmployeesPage()
        {
            InitializeComponent();
            this.DataContext = new EmployeesViewModel();
        }
    }
}
