namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Address : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "LabName", c => c.String());
            DropColumn("dbo.Products", "City");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "City", c => c.String());
            DropColumn("dbo.Products", "LabName");
        }
    }
}
