using BookStoreManagement.Models;
using BookStoreManagement.Mvvm;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace BookStoreManagement.ViewModels
{
    public class GenreWindowViewModel : BindableBase
    {
        private string _newGenreName;
        public string NewGenreName
        {
            get => _newGenreName;
            set => SetProperty(ref _newGenreName, value);
        }

        public ObservableCollection<Genre> Genres { get; }
        public ICommand AddGenreCommand { get; }
        public ICommand ConfirmCommand { get; }
        public ICommand CancelCommand { get; }

        public GenreWindowViewModel()
        {
            Genres = new ObservableCollection<Genre>();
            AddGenreCommand = new DelegateCommand(OnAddGenre);
            ConfirmCommand = new DelegateCommand(OnConfirm);
            CancelCommand = new DelegateCommand(OnCancel);
        }

        private void OnAddGenre()
        {
            // Thêm thể loại mới
        }

        private void OnConfirm()
        {
            // Xác nhận thêm thể loại
        }

        private void OnCancel()
        {
            // Đóng cửa sổ mà không làm gì
        }
    }
}
