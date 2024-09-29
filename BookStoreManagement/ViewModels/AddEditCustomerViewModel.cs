using BookStoreManagement.Models;
using BookStoreManagement.Mvvm;
using System.Windows.Input;

namespace BookStoreManagement.ViewModels
{
    public class AddEditCustomerViewModel : BindableBase
    {
        private Customer _customer;
        private string _windowTitle;
        private string _buttonContent;
        public ICommand SaveCommand { get; }
        public ICommand CancelCommand { get; }

        public Customer Customer
        {
            get => _customer;
            set => SetProperty(ref _customer, value);
        }

        public string WindowTitle
        {
            get => _windowTitle;
            set => SetProperty(ref _windowTitle, value);
        }

        public string ButtonContent
        {
            get => _buttonContent;
            set => SetProperty(ref _buttonContent, value);
        }

        public AddEditCustomerViewModel(Customer customer, bool isEditMode)
        {
            Customer = customer;
            WindowTitle = isEditMode ? "Sửa khách hàng" : "Thêm khách hàng";
            ButtonContent = isEditMode ? "Lưu" : "Thêm";
            SaveCommand = new DelegateCommand(OnSave);
            CancelCommand = new DelegateCommand(OnCancel);
        }

        private void OnSave()
        {
            CloseWindow();
        }

        private void OnCancel()
        {
            CloseWindow();
        }

        private void CloseWindow()
        {
            var window = System.Windows.Application.Current.Windows[0];
            window?.Close();
        }
    }
}
