using BookStoreManagement.ViewModels;
using System.Windows.Controls;

namespace BookStoreManagement.Views
{
    /// <summary>
    /// Interaction logic for SalesPage.xaml
    /// </summary>
    public partial class SalesPage : UserControl
    {
        public SalesPage()
        {
            InitializeComponent();
            this.DataContext = new SalesViewModel();
        }
    }
}
