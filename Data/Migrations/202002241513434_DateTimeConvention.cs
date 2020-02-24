namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DateTimeConvention : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "DateProd", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Providers", "DateCreated", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            DropColumn("dbo.Products", "Image");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Image", c => c.String());
            AlterColumn("dbo.Providers", "DateCreated", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Products", "DateProd", c => c.DateTime(nullable: false));
        }
    }
}
