using BookStoreManagement.Mvvm;
using System;
using System.Windows;
using System.Windows.Input;

namespace BookStoreManagement.ViewModels
{
    public class AuthorWindowViewModel : BindableBase
    {
        private string _newAuthorName;
        public string NewAuthorName
        {
            get => _newAuthorName;
            set => SetProperty(ref _newAuthorName, value);
        }

        public ICommand SaveCommand { get; }
        public ICommand CancelCommand { get; }

        public event Action CloseAction;

        public AuthorWindowViewModel()
        {
            SaveCommand = new DelegateCommand(OnSave, CanSave);
            CancelCommand = new DelegateCommand(OnCancel);
        }

        private bool CanSave()
        {
            return !string.IsNullOrEmpty(NewAuthorName);
        }

        private void OnSave()
        {
            MessageBox.Show($"Tác giả '{NewAuthorName}' đã được thêm thành công!", "Thành công", MessageBoxButton.OK, MessageBoxImage.Information);
            CloseAction?.Invoke();
        }

        private void OnCancel()
        {
            CloseAction?.Invoke();
        }
    }
}
