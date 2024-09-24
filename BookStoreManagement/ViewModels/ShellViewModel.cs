using System;
using System.Collections.ObjectModel;
using MahApps.Metro.IconPacks;
using BookStoreManagement.Mvvm;
using BookStoreManagement.Views;

namespace BookStoreManagement.ViewModels
{
    public class ShellViewModel : BindableBase
    {
        public ObservableCollection<MenuItem> Menu { get; } = new ObservableCollection<MenuItem>();
        public ObservableCollection<MenuItem> OptionsMenu { get; } = new ObservableCollection<MenuItem>();

        public ShellViewModel()
        {
            // Build the menus
            this.Menu.Add(new MenuItem()
            {
                Icon = new PackIconBoxIcons() { Kind = PackIconBoxIconsKind.RegularHome },
                Label = "Trang chủ",
                NavigationType = typeof(HomePage),
                NavigationDestination = new Uri("Views/HomePage.xaml", UriKind.RelativeOrAbsolute)
            });
            this.Menu.Add(new MenuItem()
            {
                Icon = new PackIconBoxIcons() { Kind = PackIconBoxIconsKind.RegularCart },
                Label = "Bán hàng",
                NavigationType = typeof(SalesPage),
                NavigationDestination = new Uri("Views/SalesPage.xaml", UriKind.RelativeOrAbsolute)
            });
            this.Menu.Add(new MenuItem()
            {
                Icon = new PackIconBoxIcons() { Kind = PackIconBoxIconsKind.RegularBox },
                Label = "Sản phẩm",
                NavigationType = typeof(ProductsPage),
                NavigationDestination = new Uri("Views/ProductsPage.xaml", UriKind.RelativeOrAbsolute)
            });
            this.Menu.Add(new MenuItem()
            {
                Icon = new PackIconFontAwesome() { Kind = PackIconFontAwesomeKind.FontAwesomeBrands },
                Label = "Thống kê",
                NavigationType = typeof(StatisticsPage),
                NavigationDestination = new Uri("Views/StatisticsPage.xaml", UriKind.RelativeOrAbsolute)
            });

            this.Menu.Add(new MenuItem()
            {
                Icon = new PackIconMaterial() { Kind = PackIconMaterialKind.AccountPlus },
                Label = "Nhân viên",
                NavigationType = typeof(EmployeesPage),
                NavigationDestination = new Uri("Views/EmployeesPage.xaml", UriKind.RelativeOrAbsolute)
            });
            this.Menu.Add(new MenuItem()
            {
                Icon = new PackIconMaterial() { Kind = PackIconMaterialKind.AccountGroup },
                Label = "Khách hàng",
                NavigationType = typeof(CustomersPage),
                NavigationDestination = new Uri("Views/CustomersPage.xaml", UriKind.RelativeOrAbsolute)
            });
            this.OptionsMenu.Add(new MenuItem()
            {
                Icon = new PackIconMaterial() { Kind = PackIconMaterialKind.Account },
                Label = "Tài khoản",
                NavigationType = typeof(AccountPage),
                NavigationDestination = new Uri("Views/AccountPage.xaml", UriKind.RelativeOrAbsolute)
            });
        }
    }
}