using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using BookStoreManagement.Models;
using BookStoreManagement.Mvvm;
using BookStoreManagement.Views;
using Microsoft.Win32;

namespace BookStoreManagement.ViewModels
{
    public class BooksViewModel : BindableBase
    {
        private string _searchKeyword;
        private Book _selectedBook;
        private ObservableCollection<Book> _books;
        private ObservableCollection<Genre> _genres;
        private ObservableCollection<Author> _authors;

        public string SearchKeyword
        {
            get => _searchKeyword;
            set => SetProperty(ref _searchKeyword, value);
        }

        public Book SelectedBook
        {
            get => _selectedBook;
            set => SetProperty(ref _selectedBook, value);
        }

        public ObservableCollection<Book> Books
        {
            get => _books;
            set => SetProperty(ref _books, value);
        }

        public ObservableCollection<Genre> Genres
        {
            get => _genres;
            set => SetProperty(ref _genres, value);
        }

        public ObservableCollection<Author> Authors
        {
            get => _authors;
            set => SetProperty(ref _authors, value);
        }

        public ICommand SearchCommand { get; }
        public ICommand AddBookCommand { get; }
        public ICommand DeleteBookCommand { get; }
        public ICommand SaveBookCommand { get; }
        public ICommand SelectImageCommand { get; }
        public ICommand OpenAddGenreWindowCommand { get; }
        public ICommand OpenAddAuthorWindowCommand { get; }

        public BooksViewModel()
        {
            _books = new ObservableCollection<Book>();
            _genres = new ObservableCollection<Genre>();
            _authors = new ObservableCollection<Author>();
            LoadSampleData();
            SearchCommand = new DelegateCommand(OnSearch);
            AddBookCommand = new DelegateCommand(OnAddBook);
            DeleteBookCommand = new DelegateCommand<Book>(OnDeleteBook);
            SaveBookCommand = new DelegateCommand(OnSaveBook);
            SelectImageCommand = new DelegateCommand(OnSelectImage);
            OpenAddGenreWindowCommand = new DelegateCommand(OnOpenAddGenreWindow);
            OpenAddAuthorWindowCommand = new DelegateCommand(OnOpenAddAuthorWindow);
        }

        private ObservableCollection<Book> _allBooks;

        private void LoadSampleData()
        {
            var author1 = new Author { AuthorID = 1, AuthorName = "Author 1" };
            var author2 = new Author { AuthorID = 2, AuthorName = "Author 2" };
            var genre1 = new Genre { GenreID = 1, GenreName = "Fiction" };
            var genre2 = new Genre { GenreID = 2, GenreName = "Non-Fiction" };

            _authors.Add(author1);
            _authors.Add(author2);
            _genres.Add(genre1);
            _genres.Add(genre2);

            _allBooks = new ObservableCollection<Book>
            {
                new Book
                {
                    BookID = 1,
                    BookName = "Sample Book 1",
                    Price = 100,
                    Quantity = 10,
                    Author = author1,
                    BookGenres = new ObservableCollection<BookGenre>
                    {
                        new BookGenre { Genre = genre1 },
                    },
                    Description = "This is a description of Sample Book 1.",
                    BookImagePath = "pack://application:,,,/Resources/sach1.jpg",
                },
                new Book
                {
                    BookID = 2,
                    BookName = "Sample Book 2",
                    Price = 200,
                    Quantity = 5,
                    Author = author2,
                    BookGenres = new ObservableCollection<BookGenre>
                    {
                        new BookGenre { Genre = genre2 },
                    },
                    Description = "This is a description of Sample Book 2.",
                    BookImagePath = "pack://application:,,,/Resources/sach2.jpg",
                },
            };

            // Đặt Books thành tất cả sách trong _allBooks ban đầu
            Books = new ObservableCollection<Book>(_allBooks);
        }

        private void OnSearch()
        {
            if (string.IsNullOrWhiteSpace(SearchKeyword))
            {
                // Khi từ khóa trống, hiển thị lại tất cả sách
                Books = new ObservableCollection<Book>(_allBooks);
            }
            else
            {
                var filteredBooks = new ObservableCollection<Book>(
                    _allBooks.Where(book =>
                        book.BookName.IndexOf(SearchKeyword, StringComparison.OrdinalIgnoreCase)
                        >= 0
                    )
                );
                Books = filteredBooks;
            }
        }

        private void OnAddBook()
        {
            // Tạo sách mới với các giá trị mặc định
            var newBook = new Book
            {
                BookID = _books.Count + 1, // Tạo ID tự động
                BookName = "Sách mới", // Đặt tên mặc định
                Price = 0, // Giá mặc định
                Quantity = 0, // Số lượng mặc định
                BookGenres = new ObservableCollection<BookGenre>(), // Thể loại mặc định
                Author =
                    Authors.FirstOrDefault() // Tác giả mặc định
                ,
            };

            // Thêm sách mới vào danh sách
            _books.Add(newBook);

            // Đặt sách mới làm đối tượng đã chọn
            SelectedBook = newBook;
        }

        private void OnDeleteBook(Book book)
        {
            if (book != null && _books.Contains(book))
            {
                _books.Remove(book);
            }
        }

        private void OnSaveBook()
        {
            if (SelectedBook != null)
            {
                if (SelectedBook.BookID == 0)
                {
                    SelectedBook.BookID = _books.Count + 1;
                    _books.Add(SelectedBook);
                }
                else { }
                SelectedBook = null;
            }
        }

        private void OnSelectImage()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png",
            };

            if (openFileDialog.ShowDialog() == true)
            {
                if (SelectedBook != null)
                {
                    string imagePath = openFileDialog.FileName;
                    SelectedBook.BookImagePath = imagePath; // Cập nhật đường dẫn ảnh trực tiếp
                }
            }
        }

        private void OnOpenAddAuthorWindow()
        {
            var authorWindow = new AuthorWindow { DataContext = new AuthorWindowViewModel() };
            authorWindow.ShowDialog();
        }

        // Mở cửa sổ thêm Thể Loại
        private void OnOpenAddGenreWindow()
        {
            var genreWindow = new GenreWindow { DataContext = new GenreWindowViewModel() };
            genreWindow.ShowDialog();
        }
    }
}
