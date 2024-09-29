using BookStoreManagement.Models;
using BookStoreManagement.Mvvm;
using System.Windows.Input;

namespace BookStoreManagement.ViewModels
{
    public class AddEditAccountViewModel : BindableBase
    {
        private Account _account;
        private string _windowTitle;
        private string _buttonContent;

        public Account Account
        {
            get => _account;
            set => SetProperty(ref _account, value);
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

        public ICommand SaveCommand { get; }
        public ICommand CancelCommand { get; }

        public AddEditAccountViewModel(Account account, bool isEditMode)
        {
            Account = account;
            WindowTitle = isEditMode ? "Sửa tài khoản" : "Thêm tài khoản";
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
