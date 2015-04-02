namespace PartiuAcademia.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v3db1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.tbUser", "AddressID", "dbo.tbAdress");
            DropIndex("dbo.tbUser", new[] { "AddressID" });
            AlterColumn("dbo.tbUser", "AddressID", c => c.String(maxLength: 128));
            CreateIndex("dbo.tbUser", "AddressID");
            AddForeignKey("dbo.tbUser", "AddressID", "dbo.tbAdress", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tbUser", "AddressID", "dbo.tbAdress");
            DropIndex("dbo.tbUser", new[] { "AddressID" });
            AlterColumn("dbo.tbUser", "AddressID", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.tbUser", "AddressID");
            AddForeignKey("dbo.tbUser", "AddressID", "dbo.tbAdress", "Id", cascadeDelete: true);
        }
    }
}
