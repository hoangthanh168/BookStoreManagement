using BookStoreManagement.ViewModels;
using System.Windows.Controls;

namespace BookStoreManagement.Views
{
    /// <summary>
    /// Interaction logic for StatisticsPage.xaml
    /// </summary>
    public partial class StatisticsPage : UserControl
    {
        public StatisticsPage()
        {
            InitializeComponent();
            this.DataContext = new StatisticsViewModel();
        }
    }
}
