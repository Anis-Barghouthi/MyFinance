namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PrimaryKeyConvention : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProviderProducts", "Provider_Id", "dbo.Providers");
            RenameColumn(table: "dbo.ProviderProducts", name: "Provider_Id", newName: "Provider_ProviderKey");
            RenameIndex(table: "dbo.ProviderProducts", name: "IX_Provider_Id", newName: "IX_Provider_ProviderKey");
            DropPrimaryKey("dbo.Providers");
            AddColumn("dbo.Providers", "ProviderKey", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Providers", "ProviderKey");
            AddForeignKey("dbo.ProviderProducts", "Provider_ProviderKey", "dbo.Providers", "ProviderKey", cascadeDelete: true);
            DropColumn("dbo.Providers", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Providers", "Id", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.ProviderProducts", "Provider_ProviderKey", "dbo.Providers");
            DropPrimaryKey("dbo.Providers");
            DropColumn("dbo.Providers", "ProviderKey");
            AddPrimaryKey("dbo.Providers", "Id");
            RenameIndex(table: "dbo.ProviderProducts", name: "IX_Provider_ProviderKey", newName: "IX_Provider_Id");
            RenameColumn(table: "dbo.ProviderProducts", name: "Provider_ProviderKey", newName: "Provider_Id");
            AddForeignKey("dbo.ProviderProducts", "Provider_Id", "dbo.Providers", "Id", cascadeDelete: true);
        }
    }
}
