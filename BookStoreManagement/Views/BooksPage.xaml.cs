using BookStoreManagement.ViewModels;
using System.Windows.Controls;

namespace BookStoreManagement.Views
{
    /// <summary>
    /// Interaction logic for BooksPage.xaml
    /// </summary>
    public partial class BooksPage : UserControl
    {
        public BooksPage()
        {
            InitializeComponent();
            this.DataContext = new BooksViewModel();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
