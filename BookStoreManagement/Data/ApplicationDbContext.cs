using BookStoreManagement.Models;
using System.Data.Entity;

namespace BookStoreManagement.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("name=BookStoreDbConnectionString")
        {
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<BookGenre> BookGenres { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceDetail> InvoiceDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Cấu hình khóa chính cho BookGenre (bảng trung gian)
            modelBuilder.Entity<BookGenre>()
                .HasKey(bg => new { bg.BookID, bg.GenreID });

            // Cấu hình quan hệ nhiều-nhiều giữa Book và Genre thông qua BookGenre
            modelBuilder.Entity<Book>()
                .HasMany(b => b.BookGenres)
                .WithRequired(bg => bg.Book)
                .HasForeignKey(bg => bg.BookID);

            modelBuilder.Entity<Genre>()
                .HasMany(g => g.BookGenres)
                .WithRequired(bg => bg.Genre)
                .HasForeignKey(bg => bg.GenreID);

            // Cấu hình quan hệ một-nhiều giữa Author và Book
            modelBuilder.Entity<Author>()
                .HasMany(a => a.Books)
                .WithRequired(b => b.Author)
                .HasForeignKey(b => b.AuthorID);

            // Cấu hình quan hệ một-nhiều giữa Customer và Invoice
            modelBuilder.Entity<Customer>()
                .HasMany(c => c.Invoices)
                .WithRequired(i => i.Customer)
                .HasForeignKey(i => i.CustomerID)
                .WillCascadeOnDelete(false);

            // Cấu hình quan hệ một-nhiều giữa Employee và Invoice
            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Invoices)
                .WithRequired(i => i.Employee)
                .HasForeignKey(i => i.EmployeeID)
                .WillCascadeOnDelete(false);

            // Cấu hình quan hệ một-nhiều giữa Invoice và InvoiceDetail
            modelBuilder.Entity<Invoice>()
                .HasMany(i => i.InvoiceDetails)
                .WithRequired(id => id.Invoice)
                .HasForeignKey(id => id.InvoiceID);

            // Cấu hình quan hệ một-nhiều giữa Book và InvoiceDetail
            modelBuilder.Entity<Book>()
                .HasMany(b => b.InvoiceDetails)
                .WithRequired(id => id.Book)
                .HasForeignKey(id => id.BookID);

            // Cấu hình quan hệ một-một giữa Employee và Account
            modelBuilder.Entity<Employee>()
                .HasRequired(e => e.Account)
                .WithRequiredDependent(a => a.Employee);

            // Cấu hình các thuộc tính khác nếu cần
            // Ví dụ: Đặt tên bảng, tên cột, ràng buộc, v.v.
        }
    }
}
