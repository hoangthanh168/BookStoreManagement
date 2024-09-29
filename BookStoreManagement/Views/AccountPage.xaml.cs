using BookStoreManagement.ViewModels;
using System.Windows.Controls;

namespace BookStoreManagement.Views
{
    /// <summary>
    /// Interaction logic for AccountPage.xaml
    /// </summary>
    public partial class AccountPage : UserControl
    {
        public AccountPage()
        {
            InitializeComponent();
            this.DataContext = new AccountViewModel();
        }
    }
}
