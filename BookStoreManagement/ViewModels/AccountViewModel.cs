using BookStoreManagement.Models;
using BookStoreManagement.Mvvm;
using BookStoreManagement.ViewModels;
using BookStoreManagement.Views;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

public class AccountViewModel : BindableBase
{
    private ObservableCollection<Account> _accounts;
    public ObservableCollection<Account> Accounts
    {
        get => _accounts;
        set => SetProperty(ref _accounts, value);
    }

    private Account _selectedAccount;
    public Account SelectedAccount
    {
        get => _selectedAccount;
        set
        {
            if (SetProperty(ref _selectedAccount, value))
            {
                ((DelegateCommand)EditAccountCommand).RaiseCanExecuteChanged();
                ((DelegateCommand)DeleteAccountCommand).RaiseCanExecuteChanged();
            }
        }
    }

    private string _searchKeyword;
    public string SearchKeyword
    {
        get => _searchKeyword;
        set
        {
            SetProperty(ref _searchKeyword, value);
        }
    }

    public int AccountCount => Accounts?.Count ?? 0;

    public ICommand SearchCommand { get; }
    public ICommand AddAccountCommand { get; }
    public ICommand EditAccountCommand { get; }
    public ICommand DeleteAccountCommand { get; }

    public AccountViewModel()
    {
        Accounts = new ObservableCollection<Account>
        {
            new Account
            {
                AccountID = 1,
                Username = "nguyenvana",
                IsAdmin = true,
                Employee = new Employee
                {
                    EmployeeID = 1,
                    FullName = "Nguyen Van A",
                }
            },
            new Account
            {
                AccountID = 2,
                Username = "lethib",
                IsAdmin = false,
                Employee = new Employee
                {
                    EmployeeID = 2,
                    FullName = "Le Thi B",
                }
            },
            new Account
            {
                AccountID = 3,
                Username = "tranvanc",
                IsAdmin = false,
                Employee = new Employee
                {
                    EmployeeID = 3,
                    FullName = "Tran Van C",
                }
            },
        };

        SearchCommand = new DelegateCommand(SearchAccounts);
        AddAccountCommand = new DelegateCommand(OnAddAccount);
        EditAccountCommand = new DelegateCommand(OnEditAccount, CanEditOrDeleteAccount);
        DeleteAccountCommand = new DelegateCommand(DeleteAccount, CanEditOrDeleteAccount);
    }

    private void SearchAccounts()
    {
        if (string.IsNullOrEmpty(SearchKeyword))
        {
            Accounts = new ObservableCollection<Account>(GetAllAccounts());
        }
        else
        {
            var filteredAccounts = GetAllAccounts()
                .Where(a =>
                    a.Username.IndexOf(SearchKeyword, StringComparison.OrdinalIgnoreCase) >= 0
                    || a.Employee.FullName.IndexOf(SearchKeyword, StringComparison.OrdinalIgnoreCase) >= 0
                )
                .ToList();

            Accounts = new ObservableCollection<Account>(filteredAccounts);
        }

        OnPropertyChanged(nameof(AccountCount));
    }

    private void OnAddAccount()
    {
        var newAccount = new Account
        {
            AccountID = Accounts.Max(a => a.AccountID) + 1,
            Username = "newuser",
            IsAdmin = false,
            Employee = new Employee
            {
                EmployeeID = Accounts.Count + 1, // Thêm nhân viên giả lập
                FullName = "New Employee"
            }
        };

        OpenAddEditAccountWindow(newAccount, false);
    }

    private void OnEditAccount()
    {
        if (SelectedAccount != null)
        {
            OpenAddEditAccountWindow(SelectedAccount, true);
        }
    }

    private void OpenAddEditAccountWindow(Account account, bool isEditMode)
    {
        var addEditAccountWindow = new AddEditAccountWindow
        {
            DataContext = new AddEditAccountViewModel(account, isEditMode),
        };

        addEditAccountWindow.ShowDialog();
    }

    private void DeleteAccount()
    {
        if (SelectedAccount != null)
        {
            Accounts.Remove(SelectedAccount);
            SelectedAccount = null;
            OnPropertyChanged(nameof(AccountCount));
        }
    }

    private bool CanEditOrDeleteAccount()
    {
        return SelectedAccount != null;
    }

    private ObservableCollection<Account> GetAllAccounts()
    {
        return new ObservableCollection<Account>
        {
            new Account
            {
                AccountID = 1,
                Username = "nguyenvana",
                IsAdmin = true,
                Employee = new Employee
                {
                    EmployeeID = 1,
                    FullName = "Nguyen Van A",
                }
            },
            new Account
            {
                AccountID = 2,
                Username = "lethib",
                IsAdmin = false,
                Employee = new Employee
                {
                    EmployeeID = 2,
                    FullName = "Le Thi B",
                }
            },
            new Account
            {
                AccountID = 3,
                Username = "tranvanc",
                IsAdmin = false,
                Employee = new Employee
                {
                    EmployeeID = 3,
                    FullName = "Tran Van C",
                }
            },
        };
    }
}
