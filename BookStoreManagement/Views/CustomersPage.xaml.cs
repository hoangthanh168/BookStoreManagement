using BookStoreManagement.ViewModels;
using System.Windows.Controls;

namespace BookStoreManagement.Views
{
    /// <summary>
    /// Interaction logic for CustomersPage.xaml
    /// </summary>
    public partial class CustomersPage : UserControl
    {
        public CustomersPage()
        {
            InitializeComponent();
            this.DataContext = new CustomersViewModel();
        }
    }
}
