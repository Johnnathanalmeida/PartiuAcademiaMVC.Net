namespace PartiuAcademia.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tbstate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tbState",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false),
                        Sigla = c.String(maxLength: 2),
                        CreationDate = c.DateTime(nullable: false),
                        CreationUser = c.String(nullable: false),
                        TerminationDate = c.DateTime(nullable: false),
                        TerminationUser = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tbState");
        }
    }
}
