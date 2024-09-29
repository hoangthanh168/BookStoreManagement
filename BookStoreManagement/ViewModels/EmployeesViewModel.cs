using BookStoreManagement.Models;
using BookStoreManagement.Mvvm;
using BookStoreManagement.Views;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace BookStoreManagement.ViewModels
{
    public class EmployeesViewModel : BindableBase
    {
        private ObservableCollection<Employee> _employees;
        private ObservableCollection<Employee> _allEmployees;
        private Employee _selectedEmployee;
        private string _searchKeyword;
        private int _employeeCount;

        public ObservableCollection<Employee> Employees
        {
            get => _employees;
            set => SetProperty(ref _employees, value);
        }

        public Employee SelectedEmployee
        {
            get => _selectedEmployee;
            set
            {
                if (SetProperty(ref _selectedEmployee, value))
                {
                    ((DelegateCommand)EditEmployeeCommand).RaiseCanExecuteChanged();
                    ((DelegateCommand)DeleteEmployeeCommand).RaiseCanExecuteChanged();
                }
            }
        }

        public string SearchKeyword
        {
            get => _searchKeyword;
            set
            {
                SetProperty(ref _searchKeyword, value);
            }
        }

        public int EmployeeCount
        {
            get => _employeeCount;
            set => SetProperty(ref _employeeCount, value);
        }

        public ICommand SearchCommand { get; }
        public ICommand AddEmployeeCommand { get; }
        public ICommand EditEmployeeCommand { get; }
        public ICommand DeleteEmployeeCommand { get; }

        public EmployeesViewModel()
        {
            Employees = new ObservableCollection<Employee>();
            _allEmployees = new ObservableCollection<Employee>();
            SearchCommand = new DelegateCommand(OnSearch);
            AddEmployeeCommand = new DelegateCommand(OnAddEmployee);
            EditEmployeeCommand = new DelegateCommand(OnEditEmployee, CanEditOrDeleteEmployee);
            DeleteEmployeeCommand = new DelegateCommand(OnDeleteEmployee, CanEditOrDeleteEmployee);
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            _allEmployees.Add(new Employee
            {
                EmployeeID = 1,
                FullName = "Nguyễn Văn A",
                Gender = "Nam",
                BirthDate = new DateTime(1990, 1, 15),
                Address = "Hà Nội",
                PhoneNumber = "0123456789",
                Email = "nguyenvana@example.com",
                HireDate = new DateTime(2015, 6, 1),
                Note = "Nhân viên kinh doanh",
                AvatarImagePath = "pack://application:,,,/Resources/default_avatar.jpg",
                Account = new Account
                {
                    Username = "nguyenvana",
                    Password = "password123",
                    IsAdmin = false
                }
            });

            _allEmployees.Add(new Employee
            {
                EmployeeID = 2,
                FullName = "Trần Thị B",
                Gender = "Nữ",
                BirthDate = new DateTime(1992, 3, 22),
                Address = "TP.HCM",
                PhoneNumber = "0987654321",
                Email = "tranthib@example.com",
                HireDate = new DateTime(2017, 9, 15),
                Note = "Nhân viên marketing",
                AvatarImagePath = "pack://application:,,,/Resources/default_avatar.jpg",
                Account = new Account
                {
                    Username = "tranthib",
                    Password = "password456",
                    IsAdmin = true
                }
            });

            Employees = new ObservableCollection<Employee>(_allEmployees);
            EmployeeCount = Employees.Count;
        }


        private void OnSearch()
        {
            if (string.IsNullOrEmpty(SearchKeyword))
            {
                Employees = new ObservableCollection<Employee>(_allEmployees);
            }
            else
            {
                Employees = new ObservableCollection<Employee>(
                    _allEmployees.Where(e =>
                        e.FullName.IndexOf(SearchKeyword, StringComparison.OrdinalIgnoreCase) >= 0
                        || e.EmployeeID.ToString()
                            .IndexOf(SearchKeyword, StringComparison.OrdinalIgnoreCase) >= 0
                    )
                );
            }

            EmployeeCount = Employees.Count;
        }

        private void OnAddEmployee()
        {
            var newEmployee = new Employee();
            OpenAddEditEmployeeWindow(newEmployee, false);
        }

        private void OnEditEmployee()
        {
            if (SelectedEmployee != null)
            {
                OpenAddEditEmployeeWindow(SelectedEmployee, true);
            }
        }

        private void OnDeleteEmployee()
        {
            if (SelectedEmployee != null)
            {
                Employees.Remove(SelectedEmployee);
                SelectedEmployee = null;
                EmployeeCount = Employees.Count;
            }
        }

        private void OpenAddEditEmployeeWindow(Employee employee, bool isEditMode)
        {
            var addEditEmployeeWindow = new AddEditEmployeeWindow
            {
                DataContext = new AddEditEmployeeViewModel(employee, isEditMode)
            };

            addEditEmployeeWindow.ShowDialog();
        }

        private bool CanEditOrDeleteEmployee()
        {
            return SelectedEmployee != null;
        }
    }
}
