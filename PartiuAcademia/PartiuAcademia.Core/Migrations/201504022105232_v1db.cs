namespace PartiuAcademia.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1db : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tbUser", "LastName", c => c.String());
            AddColumn("dbo.tbUser", "ConfirmPassword", c => c.String());
            AlterColumn("dbo.tbUser", "Password", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tbUser", "Password", c => c.String());
            DropColumn("dbo.tbUser", "ConfirmPassword");
            DropColumn("dbo.tbUser", "LastName");
        }
    }
}
