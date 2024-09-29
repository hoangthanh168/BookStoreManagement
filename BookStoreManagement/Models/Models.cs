using BookStoreManagement.Mvvm;
using System;
using System.Collections.ObjectModel;

namespace BookStoreManagement.Models
{
    public class Account
    {
        public int AccountID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
        public Employee Employee { get; set; }
    }

    public class Author
    {
        public int AuthorID { get; set; }
        public string AuthorName { get; set; }
        public ObservableCollection<Book> Books { get; set; }
    }

    public class Book : BindableBase
    {
        public int BookID { get; set; }
        public string BookName { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public int AuthorID { get; set; }
        public Author Author { get; set; }

        private string _bookImagePath;
        public string BookImagePath
        {
            get => _bookImagePath;
            set => SetProperty(ref _bookImagePath, value);
        }
        public string Description { get; set; }
        public ObservableCollection<BookGenre> BookGenres { get; set; }
        public ObservableCollection<InvoiceDetail> InvoiceDetails { get; set; }
    }

    public class Genre
    {
        public int GenreID { get; set; }
        public string GenreName { get; set; }
        public ObservableCollection<BookGenre> BookGenres { get; set; }
    }

    public class BookGenre
    {
        public int BookID { get; set; }
        public Book Book { get; set; }
        public int GenreID { get; set; }
        public Genre Genre { get; set; }
    }

    public class Customer
    {
        public int CustomerID { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string Note { get; set; }
        public DateTime CreatedDate { get; set; }
        public ObservableCollection<Invoice> Invoices { get; set; }
    }

    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime BirthDate { get; set; }
        public string Note { get; set; }
        public string AvatarImagePath { get; set; }
        public string Gender { get; set; }

        public int AccountID { get; set; }
        public Account Account { get; set; }

        public ObservableCollection<Invoice> Invoices { get; set; }
    }

    public class Invoice
    {
        public int InvoiceID { get; set; }
        public DateTime InvoiceDate { get; set; }
        public float AmountPaid { get; set; }
        public int CustomerID { get; set; }
        public int EmployeeID { get; set; }

        public Customer Customer { get; set; }
        public Employee Employee { get; set; }

        public ObservableCollection<InvoiceDetail> InvoiceDetails { get; set; }
    }

    public class InvoiceDetail
    {
        public int InvoiceDetailID { get; set; }
        public int Quantity { get; set; }
        public float SalePrice { get; set; }
        public int BookID { get; set; }
        public int InvoiceID { get; set; }

        public Book Book { get; set; }
        public Invoice Invoice { get; set; }
    }
}
