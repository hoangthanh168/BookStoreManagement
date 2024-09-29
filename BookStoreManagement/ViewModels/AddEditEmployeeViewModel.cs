using BookStoreManagement.Models;
using BookStoreManagement.Mvvm;
using System.Windows.Input;

namespace BookStoreManagement.ViewModels
{
    public class AddEditEmployeeViewModel : BindableBase
    {
        private Employee _employee;
        private string _windowTitle;
        private string _buttonContent;
        public ICommand SaveCommand { get; }
        public ICommand CancelCommand { get; }

        public Employee Employee
        {
            get => _employee;
            set => SetProperty(ref _employee, value);
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

        public AddEditEmployeeViewModel(Employee employee, bool isEditMode)
        {
            Employee = employee;
            WindowTitle = isEditMode ? "Sửa nhân viên" : "Thêm nhân viên";
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
