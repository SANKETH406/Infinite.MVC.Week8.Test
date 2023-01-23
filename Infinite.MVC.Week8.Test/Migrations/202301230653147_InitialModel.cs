namespace Infinite.MVC.Week8.Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PackSizes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Packsize = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        Price = c.Double(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Discount = c.Single(nullable: false),
                        TotalPrice = c.Double(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        PacksizeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.PackSizes", t => t.PacksizeId, cascadeDelete: true)
                .Index(t => t.CategoryId)
                .Index(t => t.PacksizeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "PacksizeId", "dbo.PackSizes");
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "PacksizeId" });
            DropIndex("dbo.Products", new[] { "CategoryId" });
            DropTable("dbo.Products");
            DropTable("dbo.PackSizes");
            DropTable("dbo.Categories");
        }
    }
}
