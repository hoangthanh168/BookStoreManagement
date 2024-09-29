using BookStoreManagement.Models;
using BookStoreManagement.Mvvm;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace BookStoreManagement.ViewModels
{
    public class SalesViewModel : BindableBase
    {
        private Customer _selectedCustomer;
        private ObservableCollection<Book> _bookList;
        private ObservableCollection<CartItem> _cartItems;
        private string _searchKeyword;
        private string _selectedSortOption;
        private float _totalPrice;
        private float _paymentAmount;
        private float _changeAmount;
        private DateTime _invoiceDate;
        private string _employeeName;

        public SalesViewModel()
        {
            BookList = new ObservableCollection<Book>();
            CartItems = new ObservableCollection<CartItem>();
            AddToCartCommand = new DelegateCommand<Book>(AddToCart);
            RemoveFromCartCommand = new DelegateCommand<CartItem>(RemoveFromCart);
            CheckoutCommand = new DelegateCommand(Checkout);
            LoadSampleData();
            EmployeeName = "John Doe";
            InvoiceDate = DateTime.Now;
        }

        public Customer SelectedCustomer
        {
            get => _selectedCustomer;
            set => SetProperty(ref _selectedCustomer, value);
        }

        public ObservableCollection<Book> BookList
        {
            get => _bookList;
            set => SetProperty(ref _bookList, value);
        }

        public ObservableCollection<CartItem> CartItems
        {
            get => _cartItems;
            set => SetProperty(ref _cartItems, value);
        }

        public string SearchKeyword
        {
            get => _searchKeyword;
            set
            {
                if (SetProperty(ref _searchKeyword, value))
                {
                    SearchBooks();
                }
            }
        }

        public string SelectedSortOption
        {
            get => _selectedSortOption;
            set
            {
                if (SetProperty(ref _selectedSortOption, value))
                {
                    SortBooks();
                }
            }
        }

        public float TotalPrice
        {
            get => _totalPrice;
            set => SetProperty(ref _totalPrice, value);
        }

        public float PaymentAmount
        {
            get => _paymentAmount;
            set
            {
                if (SetProperty(ref _paymentAmount, value))
                {
                    ChangeAmount = _paymentAmount - _totalPrice;
                }
            }
        }

        public float ChangeAmount
        {
            get => _changeAmount;
            set => SetProperty(ref _changeAmount, value);
        }

        public DateTime InvoiceDate
        {
            get => _invoiceDate;
            set => SetProperty(ref _invoiceDate, value);
        }

        public string EmployeeName
        {
            get => _employeeName;
            set => SetProperty(ref _employeeName, value);
        }

        public ICommand AddToCartCommand { get; }
        public ICommand RemoveFromCartCommand { get; }
        public ICommand CheckoutCommand { get; }

        private void AddToCart(Book book)
        {
            if (book == null)
                return;

            var existingCartItem = CartItems.FirstOrDefault(ci => ci.Book.BookID == book.BookID);
            if (existingCartItem != null)
            {
                existingCartItem.Quantity++;
                existingCartItem.TotalPrice = existingCartItem.Quantity * existingCartItem.SalePrice;
            }
            else
            {
                CartItems.Add(new CartItem
                {
                    Book = book,
                    SalePrice = book.Price,
                    Quantity = 1,
                    TotalPrice = book.Price,
                });
            }

            CalculateTotalPrice();
        }

        private void RemoveFromCart(CartItem cartItem)
        {
            if (cartItem == null)
                return;

            CartItems.Remove(cartItem);
            CalculateTotalPrice();
        }

        private void Checkout()
        {
            if (PaymentAmount < TotalPrice)
            {
                return;
            }

            InvoiceDate = DateTime.Now;

            var invoiceWindow = new Views.InvoiceWindow
            {
                DataContext = this,
            };
            invoiceWindow.ShowDialog();

            CartItems.Clear();
            TotalPrice = 0;
            PaymentAmount = 0;
            ChangeAmount = 0;
        }

        private void CalculateTotalPrice()
        {
            TotalPrice = CartItems.Sum(ci => ci.TotalPrice);
            ChangeAmount = PaymentAmount - TotalPrice;
        }

        private void SearchBooks()
        {
        }

        private void SortBooks()
        {
        }

        private void LoadSampleData()
        {
            BookList.Add(new Book
            {
                BookID = 3,
                BookName = "Clean Code: A Handbook of Agile Software Craftsmanship",
                Price = 60000,
                Quantity = 12,
                Author = new Author { AuthorID = 3, AuthorName = "Robert C. Martin" },
                BookGenres = new ObservableCollection<BookGenre>
                {
                    new BookGenre
                    {
                        Genre = new Genre { GenreID = 3, GenreName = "Software Development" },
                    },
                },
                BookImagePath = "pack://application:,,,/Resources/sach1.jpg",
            });

            BookList.Add(new Book
            {
                BookID = 4,
                BookName = "The Pragmatic Programmer: Your Journey to Mastery",
                Price = 65000,
                Quantity = 8,
                Author = new Author { AuthorID = 4, AuthorName = "Andrew Hunt & David Thomas" },
                BookGenres = new ObservableCollection<BookGenre>
                {
                    new BookGenre
                    {
                        Genre = new Genre { GenreID = 4, GenreName = "Software Engineering" },
                    },
                },
                BookImagePath = "pack://application:,,,/Resources/sach2.jpg",
            });

            BookList.Add(new Book
            {
                BookID = 5,
                BookName = "Introduction to Algorithms",
                Price = 85000,
                Quantity = 6,
                Author = new Author
                {
                    AuthorID = 5,
                    AuthorName = "Thomas H. Cormen, Charles E. Leiserson, Ronald L. Rivest, and Clifford Stein",
                },
                BookGenres = new ObservableCollection<BookGenre>
                {
                    new BookGenre
                    {
                        Genre = new Genre { GenreID = 5, GenreName = "Algorithms" },
                    },
                },
                BookImagePath = "pack://application:,,,/Resources/sach3.jpg",
            });

            BookList.Add(new Book
            {
                BookID = 6,
                BookName = "You Don’t Know JS",
                Price = 55000,
                Quantity = 15,
                Author = new Author { AuthorID = 6, AuthorName = "Kyle Simpson" },
                BookGenres = new ObservableCollection<BookGenre>
                {
                    new BookGenre
                    {
                        Genre = new Genre { GenreID = 6, GenreName = "JavaScript" },
                    },
                },
                BookImagePath = "pack://application:,,,/Resources/sach4.jpg",
            });
        }
    }

    public class CartItem : BindableBase
    {
        private int _quantity;
        private float _totalPrice;

        public Book Book { get; set; }
        public float SalePrice { get; set; }
        public string BookName => Book?.BookName;

        public int Quantity
        {
            get => _quantity;
            set
            {
                if (SetProperty(ref _quantity, value))
                {
                    TotalPrice = SalePrice * _quantity;
                }
            }
        }

        public float TotalPrice
        {
            get => _totalPrice;
            set => SetProperty(ref _totalPrice, value);
        }
    }
}
