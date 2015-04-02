namespace PartiuAcademia.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2db : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tbCategory",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        CreationDate = c.DateTime(nullable: false),
                        CreationUser = c.String(),
                        TerminationDate = c.DateTime(nullable: false),
                        TerminationUser = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tbCity",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        CreationDate = c.DateTime(nullable: false),
                        CreationUser = c.String(),
                        TerminationDate = c.DateTime(nullable: false),
                        TerminationUser = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tbDistrict",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        CreationDate = c.DateTime(nullable: false),
                        CreationUser = c.String(),
                        TerminationDate = c.DateTime(nullable: false),
                        TerminationUser = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tbExercise",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Series = c.Int(nullable: false),
                        Repety = c.Int(nullable: false),
                        Carga = c.Int(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                        CreationUser = c.String(),
                        TerminationDate = c.DateTime(nullable: false),
                        TerminationUser = c.String(),
                        Category_Id = c.String(maxLength: 128),
                        TrainingRecord_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tbCategory", t => t.Category_Id)
                .ForeignKey("dbo.tbTrainingRecord", t => t.TrainingRecord_Id)
                .Index(t => t.Category_Id)
                .Index(t => t.TrainingRecord_Id);
            
            CreateTable(
                "dbo.tbFrequency",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        CreationDate = c.DateTime(nullable: false),
                        CreationUser = c.String(),
                        TerminationDate = c.DateTime(nullable: false),
                        TerminationUser = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tbGym",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        CreationDate = c.DateTime(nullable: false),
                        CreationUser = c.String(),
                        TerminationDate = c.DateTime(nullable: false),
                        TerminationUser = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tbModality",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        CreationDate = c.DateTime(nullable: false),
                        CreationUser = c.String(),
                        TerminationDate = c.DateTime(nullable: false),
                        TerminationUser = c.String(),
                        Gym_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tbGym", t => t.Gym_Id)
                .Index(t => t.Gym_Id);
            
            CreateTable(
                "dbo.tbGymUserModality",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        CreationDate = c.DateTime(nullable: false),
                        CreationUser = c.String(),
                        TerminationDate = c.DateTime(nullable: false),
                        TerminationUser = c.String(),
                        Gym_Id = c.String(maxLength: 128),
                        Modality_Id = c.String(maxLength: 128),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tbGym", t => t.Gym_Id)
                .ForeignKey("dbo.tbModality", t => t.Modality_Id)
                .ForeignKey("dbo.tbUser", t => t.User_Id)
                .Index(t => t.Gym_Id)
                .Index(t => t.Modality_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.tbTrainingRecord",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        CreationDate = c.DateTime(nullable: false),
                        CreationUser = c.String(),
                        TerminationDate = c.DateTime(nullable: false),
                        TerminationUser = c.String(),
                        GymUserModality_Id = c.String(maxLength: 128),
                        Training_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tbGymUserModality", t => t.GymUserModality_Id)
                .ForeignKey("dbo.tbTraining", t => t.Training_Id)
                .Index(t => t.GymUserModality_Id)
                .Index(t => t.Training_Id);
            
            CreateTable(
                "dbo.tbUser",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        Telephone = c.String(),
                        CellPhone = c.String(),
                        AddressID = c.String(nullable: false, maxLength: 128),
                        RoleID = c.String(nullable: false, maxLength: 128),
                        CreationDate = c.DateTime(nullable: false),
                        CreationUser = c.String(),
                        TerminationDate = c.DateTime(nullable: false),
                        TerminationUser = c.String(),
                        Team_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tbAdress", t => t.AddressID, cascadeDelete: true)
                .ForeignKey("dbo.tbRole", t => t.RoleID, cascadeDelete: true)
                .ForeignKey("dbo.tbTeam", t => t.Team_Id)
                .Index(t => t.AddressID)
                .Index(t => t.RoleID)
                .Index(t => t.Team_Id);
            
            CreateTable(
                "dbo.tbAdress",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        CEP = c.String(),
                        Patio = c.String(),
                        Bairro = c.String(),
                        Cidade = c.String(),
                        Estado = c.String(),
                        Number = c.String(),
                        Complement = c.String(),
                        CreationDate = c.DateTime(nullable: false),
                        CreationUser = c.String(),
                        TerminationDate = c.DateTime(nullable: false),
                        TerminationUser = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tbRole",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        CreationDate = c.DateTime(nullable: false),
                        CreationUser = c.String(),
                        TerminationDate = c.DateTime(nullable: false),
                        TerminationUser = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tbHorary",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        FirstHour = c.Time(nullable: false, precision: 7),
                        FinalHour = c.Time(nullable: false, precision: 7),
                        DayOfWeek = c.Int(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                        CreationUser = c.String(),
                        TerminationDate = c.DateTime(nullable: false),
                        TerminationUser = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tbState",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false),
                        Sigla = c.String(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                        CreationUser = c.String(),
                        TerminationDate = c.DateTime(nullable: false),
                        TerminationUser = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tbTeam",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        CreationDate = c.DateTime(nullable: false),
                        CreationUser = c.String(),
                        TerminationDate = c.DateTime(nullable: false),
                        TerminationUser = c.String(),
                        Horary_Id = c.String(maxLength: 128),
                        Modality_Id = c.String(maxLength: 128),
                        Teacher_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tbHorary", t => t.Horary_Id)
                .ForeignKey("dbo.tbModality", t => t.Modality_Id)
                .ForeignKey("dbo.tbUser", t => t.Teacher_Id)
                .Index(t => t.Horary_Id)
                .Index(t => t.Modality_Id)
                .Index(t => t.Teacher_Id);
            
            CreateTable(
                "dbo.tbTraining",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Objetivo = c.Int(nullable: false),
                        Observation = c.String(),
                        Duration = c.Int(nullable: false),
                        Status = c.Boolean(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                        CreationUser = c.String(),
                        TerminationDate = c.DateTime(nullable: false),
                        TerminationUser = c.String(),
                        Teacher_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tbUser", t => t.Teacher_Id)
                .Index(t => t.Teacher_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tbTraining", "Teacher_Id", "dbo.tbUser");
            DropForeignKey("dbo.tbTrainingRecord", "Training_Id", "dbo.tbTraining");
            DropForeignKey("dbo.tbTeam", "Teacher_Id", "dbo.tbUser");
            DropForeignKey("dbo.tbTeam", "Modality_Id", "dbo.tbModality");
            DropForeignKey("dbo.tbUser", "Team_Id", "dbo.tbTeam");
            DropForeignKey("dbo.tbTeam", "Horary_Id", "dbo.tbHorary");
            DropForeignKey("dbo.tbUser", "RoleID", "dbo.tbRole");
            DropForeignKey("dbo.tbGymUserModality", "User_Id", "dbo.tbUser");
            DropForeignKey("dbo.tbUser", "AddressID", "dbo.tbAdress");
            DropForeignKey("dbo.tbTrainingRecord", "GymUserModality_Id", "dbo.tbGymUserModality");
            DropForeignKey("dbo.tbExercise", "TrainingRecord_Id", "dbo.tbTrainingRecord");
            DropForeignKey("dbo.tbGymUserModality", "Modality_Id", "dbo.tbModality");
            DropForeignKey("dbo.tbGymUserModality", "Gym_Id", "dbo.tbGym");
            DropForeignKey("dbo.tbModality", "Gym_Id", "dbo.tbGym");
            DropForeignKey("dbo.tbExercise", "Category_Id", "dbo.tbCategory");
            DropIndex("dbo.tbTraining", new[] { "Teacher_Id" });
            DropIndex("dbo.tbTeam", new[] { "Teacher_Id" });
            DropIndex("dbo.tbTeam", new[] { "Modality_Id" });
            DropIndex("dbo.tbTeam", new[] { "Horary_Id" });
            DropIndex("dbo.tbUser", new[] { "Team_Id" });
            DropIndex("dbo.tbUser", new[] { "RoleID" });
            DropIndex("dbo.tbUser", new[] { "AddressID" });
            DropIndex("dbo.tbTrainingRecord", new[] { "Training_Id" });
            DropIndex("dbo.tbTrainingRecord", new[] { "GymUserModality_Id" });
            DropIndex("dbo.tbGymUserModality", new[] { "User_Id" });
            DropIndex("dbo.tbGymUserModality", new[] { "Modality_Id" });
            DropIndex("dbo.tbGymUserModality", new[] { "Gym_Id" });
            DropIndex("dbo.tbModality", new[] { "Gym_Id" });
            DropIndex("dbo.tbExercise", new[] { "TrainingRecord_Id" });
            DropIndex("dbo.tbExercise", new[] { "Category_Id" });
            DropTable("dbo.tbTraining");
            DropTable("dbo.tbTeam");
            DropTable("dbo.tbState");
            DropTable("dbo.tbHorary");
            DropTable("dbo.tbRole");
            DropTable("dbo.tbAdress");
            DropTable("dbo.tbUser");
            DropTable("dbo.tbTrainingRecord");
            DropTable("dbo.tbGymUserModality");
            DropTable("dbo.tbModality");
            DropTable("dbo.tbGym");
            DropTable("dbo.tbFrequency");
            DropTable("dbo.tbExercise");
            DropTable("dbo.tbDistrict");
            DropTable("dbo.tbCity");
            DropTable("dbo.tbCategory");
        }
    }
}
