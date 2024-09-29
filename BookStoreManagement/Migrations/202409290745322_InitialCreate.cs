namespace BookStoreManagement.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                {
                    AccountID = c.Int(nullable: false),
                    Email = c.String(),
                    Password = c.String(),
                    FullName = c.String(),
                    IsAdmin = c.Boolean(nullable: false),
                })
                .PrimaryKey(t => t.AccountID)
                .ForeignKey("dbo.Employees", t => t.AccountID)
                .Index(t => t.AccountID);

            CreateTable(
                "dbo.Employees",
                c => new
                {
                    EmployeeID = c.Int(nullable: false, identity: true),
                    FullName = c.String(),
                    Address = c.String(),
                    PhoneNumber = c.String(),
                    Email = c.String(),
                    HireDate = c.DateTime(nullable: false),
                    BirthDate = c.DateTime(nullable: false),
                    Note = c.String(),
                    AccountID = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.EmployeeID);

            CreateTable(
                "dbo.Invoices",
                c => new
                {
                    InvoiceID = c.Int(nullable: false, identity: true),
                    InvoiceDate = c.DateTime(nullable: false),
                    AmountPaid = c.Single(nullable: false),
                    TotalAmount = c.Single(nullable: false),
                    CustomerID = c.Int(nullable: false),
                    EmployeeID = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.InvoiceID)
                .ForeignKey("dbo.Customers", t => t.CustomerID, cascadeDelete: true)
                .ForeignKey("dbo.Employees", t => t.EmployeeID, cascadeDelete: true)
                .Index(t => t.CustomerID)
                .Index(t => t.EmployeeID);

            CreateTable(
                "dbo.Customers",
                c => new
                {
                    CustomerID = c.Int(nullable: false, identity: true),
                    FullName = c.String(),
                    Address = c.String(),
                    PhoneNumber = c.String(),
                    Email = c.String(),
                    BirthDate = c.DateTime(nullable: false),
                    Note = c.String(),
                })
                .PrimaryKey(t => t.CustomerID);

            CreateTable(
                "dbo.InvoiceDetails",
                c => new
                {
                    InvoiceDetailID = c.Int(nullable: false, identity: true),
                    Quantity = c.Int(nullable: false),
                    SalePrice = c.Single(nullable: false),
                    BookID = c.Int(nullable: false),
                    InvoiceID = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.InvoiceDetailID)
                .ForeignKey("dbo.Books", t => t.BookID, cascadeDelete: true)
                .ForeignKey("dbo.Invoices", t => t.InvoiceID, cascadeDelete: true)
                .Index(t => t.BookID)
                .Index(t => t.InvoiceID);

            CreateTable(
                "dbo.Books",
                c => new
                {
                    BookID = c.Int(nullable: false, identity: true),
                    BookName = c.String(),
                    Price = c.Single(nullable: false),
                    Quantity = c.Int(nullable: false),
                    AuthorID = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.BookID)
                .ForeignKey("dbo.Authors", t => t.AuthorID)
                .Index(t => t.AuthorID);

            CreateTable(
                "dbo.Authors",
                c => new
                {
                    AuthorID = c.Int(nullable: false, identity: true),
                    AuthorName = c.String(),
                })
                .PrimaryKey(t => t.AuthorID);

            CreateTable(
                "dbo.BookGenres",
                c => new
                {
                    BookID = c.Int(nullable: false),
                    GenreID = c.Int(nullable: false),
                })
                .PrimaryKey(t => new { t.BookID, t.GenreID })
                .ForeignKey("dbo.Genres", t => t.GenreID, cascadeDelete: true)
                .ForeignKey("dbo.Books", t => t.BookID, cascadeDelete: true)
                .Index(t => t.BookID)
                .Index(t => t.GenreID);

            CreateTable(
                "dbo.Genres",
                c => new
                {
                    GenreID = c.Int(nullable: false, identity: true),
                    GenreName = c.String(),
                })
                .PrimaryKey(t => t.GenreID);

        }

        public override void Down()
        {
            DropForeignKey("dbo.InvoiceDetails", "InvoiceID", "dbo.Invoices");
            DropForeignKey("dbo.InvoiceDetails", "BookID", "dbo.Books");
            DropForeignKey("dbo.BookGenres", "BookID", "dbo.Books");
            DropForeignKey("dbo.BookGenres", "GenreID", "dbo.Genres");
            DropForeignKey("dbo.Books", "AuthorID", "dbo.Authors");
            DropForeignKey("dbo.Invoices", "EmployeeID", "dbo.Employees");
            DropForeignKey("dbo.Invoices", "CustomerID", "dbo.Customers");
            DropForeignKey("dbo.Accounts", "AccountID", "dbo.Employees");
            DropIndex("dbo.BookGenres", new[] { "GenreID" });
            DropIndex("dbo.BookGenres", new[] { "BookID" });
            DropIndex("dbo.Books", new[] { "AuthorID" });
            DropIndex("dbo.InvoiceDetails", new[] { "InvoiceID" });
            DropIndex("dbo.InvoiceDetails", new[] { "BookID" });
            DropIndex("dbo.Invoices", new[] { "EmployeeID" });
            DropIndex("dbo.Invoices", new[] { "CustomerID" });
            DropIndex("dbo.Accounts", new[] { "AccountID" });
            DropTable("dbo.Genres");
            DropTable("dbo.BookGenres");
            DropTable("dbo.Authors");
            DropTable("dbo.Books");
            DropTable("dbo.InvoiceDetails");
            DropTable("dbo.Customers");
            DropTable("dbo.Invoices");
            DropTable("dbo.Employees");
            DropTable("dbo.Accounts");
        }
    }
}
