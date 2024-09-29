namespace BookStoreManagement.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class UpdateCustomerModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "CreatedDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Invoices", "TotalAmount");
        }

        public override void Down()
        {
            AddColumn("dbo.Invoices", "TotalAmount", c => c.Single(nullable: false));
            DropColumn("dbo.Customers", "CreatedDate");
        }
    }
}
