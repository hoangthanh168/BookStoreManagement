using BookStoreManagement.Models;
using BookStoreManagement.Mvvm;
using BookStoreManagement.Views;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace BookStoreManagement.ViewModels
{
    public class CustomersViewModel : BindableBase
    {
        private ObservableCollection<Customer> _customers;
        private Customer _selectedCustomer;
        private string _searchKeyword;
        private int _customerCount;

        public ObservableCollection<Customer> Customers
        {
            get => _customers;
            set => SetProperty(ref _customers, value);
        }

        public Customer SelectedCustomer
        {
            get => _selectedCustomer;
            set
            {
                if (SetProperty(ref _selectedCustomer, value))
                {
                    ((DelegateCommand)EditCustomerCommand).RaiseCanExecuteChanged();
                    ((DelegateCommand)DeleteCustomerCommand).RaiseCanExecuteChanged();
                }
            }
        }

        public string SearchKeyword
        {
            get => _searchKeyword;
            set => SetProperty(ref _searchKeyword, value);
        }

        public int CustomerCount
        {
            get => _customerCount;
            set => SetProperty(ref _customerCount, value);
        }

        public ICommand SearchCommand { get; }
        public ICommand AddCustomerCommand { get; }
        public ICommand EditCustomerCommand { get; }
        public ICommand DeleteCustomerCommand { get; }

        public CustomersViewModel()
        {
            Customers = new ObservableCollection<Customer>();
            SearchCommand = new DelegateCommand(OnSearch);
            AddCustomerCommand = new DelegateCommand(OnAddCustomer);
            EditCustomerCommand = new DelegateCommand(OnEditCustomer, CanEditOrDeleteCustomer);
            DeleteCustomerCommand = new DelegateCommand(OnDeleteCustomer, CanEditOrDeleteCustomer);
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            Customers.Add(new Customer
            {
                CustomerID = 1,
                FullName = "John Doe",
                Address = "123 Main St",
                PhoneNumber = "123-456-7890",
                Email = "john.doe@example.com",
                BirthDate = new DateTime(1990, 1, 1),
                CreatedDate = DateTime.Now,
                Note = "Frequent buyer",
            });

            Customers.Add(new Customer
            {
                CustomerID = 2,
                FullName = "Jane Smith",
                Address = "456 Elm St",
                PhoneNumber = "987-654-3210",
                Email = "jane.smith@example.com",
                BirthDate = new DateTime(1985, 5, 12),
                CreatedDate = DateTime.Now,
                Note = "New customer",
            });

            Customers.Add(new Customer
            {
                CustomerID = 3,
                FullName = "Bob Johnson",
                Address = "789 Oak St",
                PhoneNumber = "456-789-1230",
                Email = "bob.johnson@example.com",
                BirthDate = new DateTime(1975, 10, 20),
                CreatedDate = DateTime.Now,
                Note = "Loyal customer",
            });

            CustomerCount = Customers.Count;
        }

        private void OnSearch()
        {
            if (string.IsNullOrEmpty(SearchKeyword))
            {
                LoadCustomers();
            }
            else
            {
                var keyword = SearchKeyword.ToLower();
                var filteredCustomers = new ObservableCollection<Customer>(
                    Customers.Where(c =>
                        c.FullName.ToLower().Contains(keyword)
                        || c.Address.ToLower().Contains(keyword)
                        || c.Email.ToLower().Contains(keyword)
                    )
                );

                Customers = filteredCustomers;
            }

            CustomerCount = Customers.Count;
        }

        private void OnAddCustomer()
        {
            var newCustomer = new Customer();
            OpenAddEditCustomerWindow(newCustomer, false);
        }

        private void OnEditCustomer()
        {
            if (SelectedCustomer != null)
            {
                OpenAddEditCustomerWindow(SelectedCustomer, true);
            }
        }

        private void OpenAddEditCustomerWindow(Customer customer, bool isEditMode)
        {
            var addEditCustomerWindow = new AddEditCustomerWindow
            {
                DataContext = new AddEditCustomerViewModel(customer, isEditMode),
            };

            addEditCustomerWindow.ShowDialog();
        }

        private void OnDeleteCustomer()
        {
            if (SelectedCustomer != null)
            {
                Customers.Remove(SelectedCustomer);
                SelectedCustomer = null;
                CustomerCount = Customers.Count;
            }
        }

        private bool CanEditOrDeleteCustomer()
        {
            return SelectedCustomer != null;
        }
    }
}
