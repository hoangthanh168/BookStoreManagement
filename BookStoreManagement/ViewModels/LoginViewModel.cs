using BookStoreManagement.Mvvm;
using System.Windows;
using System.Windows.Input;

namespace BookStoreManagement.ViewModels
{
    public class LoginViewModel : BindableBase
    {
        private string _username;
        private string _password;
        private string _errorMessage;
        private bool _isErrorVisible;

        public LoginViewModel()
        {
            LoginCommand = new DelegateCommand(OnLogin);
        }

        public string Username
        {
            get => _username;
            set => SetProperty(ref _username, value);
        }

        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }

        public string ErrorMessage
        {
            get => _errorMessage;
            set => SetProperty(ref _errorMessage, value);
        }

        public bool IsErrorVisible
        {
            get => _isErrorVisible;
            set => SetProperty(ref _isErrorVisible, value);
        }

        public ICommand LoginCommand { get; }

        private void OnLogin()
        {
            MessageBox.Show("Login feature is not implemented yet.");
        }
    }
}
