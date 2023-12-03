namespace WpfApp3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(nullable: false, maxLength: 50),
                        CustomerPhone = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        ProductName = c.String(nullable: false, maxLength: 50),
                        OrderDate = c.DateTime(nullable: false),
                        customers_CustomerId = c.Int(),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.Customers", t => t.customers_CustomerId)
                .Index(t => t.customers_CustomerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "customers_CustomerId", "dbo.Customers");
            DropIndex("dbo.Orders", new[] { "customers_CustomerId" });
            DropTable("dbo.Orders");
            DropTable("dbo.Customers");
        }
    }
}
