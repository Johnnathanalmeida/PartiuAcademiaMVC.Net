namespace PartiuAcademia.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1db : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tbAdress",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Patio = c.String(),
                        Number = c.String(),
                        CEP = c.String(),
                        Complement = c.String(),
                        CreationDate = c.DateTime(nullable: false),
                        CreationUser = c.String(nullable: false),
                        TerminationDate = c.DateTime(nullable: false),
                        TerminationUser = c.String(nullable: false),
                        District_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tbDistrict", t => t.District_Id)
                .Index(t => t.District_Id);
            
            CreateTable(
                "dbo.tbDistrict",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                        CreationUser = c.String(nullable: false),
                        TerminationDate = c.DateTime(nullable: false),
                        TerminationUser = c.String(nullable: false),
                        City_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tbCity", t => t.City_Id)
                .Index(t => t.City_Id);
            
            CreateTable(
                "dbo.tbCity",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                        CreationUser = c.String(nullable: false),
                        TerminationDate = c.DateTime(nullable: false),
                        TerminationUser = c.String(nullable: false),
                        State_Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tbState", t => t.State_Id, cascadeDelete: true)
                .Index(t => t.State_Id);
            
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
            
            CreateTable(
                "dbo.tbCategory",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        CreationDate = c.DateTime(nullable: false),
                        CreationUser = c.String(nullable: false),
                        TerminationDate = c.DateTime(nullable: false),
                        TerminationUser = c.String(nullable: false),
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
                        CreationUser = c.String(nullable: false),
                        TerminationDate = c.DateTime(nullable: false),
                        TerminationUser = c.String(nullable: false),
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
                        CreationUser = c.String(nullable: false),
                        TerminationDate = c.DateTime(nullable: false),
                        TerminationUser = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tbGym",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        CreationDate = c.DateTime(nullable: false),
                        CreationUser = c.String(nullable: false),
                        TerminationDate = c.DateTime(nullable: false),
                        TerminationUser = c.String(nullable: false),
                        Address_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tbAdress", t => t.Address_Id)
                .Index(t => t.Address_Id);
            
            CreateTable(
                "dbo.tbModality",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        CreationDate = c.DateTime(nullable: false),
                        CreationUser = c.String(nullable: false),
                        TerminationDate = c.DateTime(nullable: false),
                        TerminationUser = c.String(nullable: false),
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
                        CreationUser = c.String(nullable: false),
                        TerminationDate = c.DateTime(nullable: false),
                        TerminationUser = c.String(nullable: false),
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
                        CreationUser = c.String(nullable: false),
                        TerminationDate = c.DateTime(nullable: false),
                        TerminationUser = c.String(nullable: false),
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
                        CreationDate = c.DateTime(nullable: false),
                        CreationUser = c.String(nullable: false),
                        TerminationDate = c.DateTime(nullable: false),
                        TerminationUser = c.String(nullable: false),
                        Address_Id = c.String(maxLength: 128),
                        AddressID_Id = c.String(maxLength: 128),
                        Role_Id = c.String(maxLength: 128),
                        RoleID_Id = c.String(maxLength: 128),
                        Team_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tbAdress", t => t.Address_Id)
                .ForeignKey("dbo.tbAdress", t => t.AddressID_Id)
                .ForeignKey("dbo.tbRole", t => t.Role_Id)
                .ForeignKey("dbo.tbRole", t => t.RoleID_Id)
                .ForeignKey("dbo.tbTeam", t => t.Team_Id)
                .Index(t => t.Address_Id)
                .Index(t => t.AddressID_Id)
                .Index(t => t.Role_Id)
                .Index(t => t.RoleID_Id)
                .Index(t => t.Team_Id);
            
            CreateTable(
                "dbo.tbRole",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        CreationDate = c.DateTime(nullable: false),
                        CreationUser = c.String(nullable: false),
                        TerminationDate = c.DateTime(nullable: false),
                        TerminationUser = c.String(nullable: false),
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
                        CreationUser = c.String(nullable: false),
                        TerminationDate = c.DateTime(nullable: false),
                        TerminationUser = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tbTeam",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        CreationDate = c.DateTime(nullable: false),
                        CreationUser = c.String(nullable: false),
                        TerminationDate = c.DateTime(nullable: false),
                        TerminationUser = c.String(nullable: false),
                        Horary_Id = c.String(maxLength: 128),
                        Modality_Id = c.String(maxLength: 128),
                        ModalityID_Id = c.String(maxLength: 128),
                        Teacher_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tbHorary", t => t.Horary_Id)
                .ForeignKey("dbo.tbModality", t => t.Modality_Id)
                .ForeignKey("dbo.tbModality", t => t.ModalityID_Id)
                .ForeignKey("dbo.tbUser", t => t.Teacher_Id)
                .Index(t => t.Horary_Id)
                .Index(t => t.Modality_Id)
                .Index(t => t.ModalityID_Id)
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
                        CreationUser = c.String(nullable: false),
                        TerminationDate = c.DateTime(nullable: false),
                        TerminationUser = c.String(nullable: false),
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
            DropForeignKey("dbo.tbTeam", "ModalityID_Id", "dbo.tbModality");
            DropForeignKey("dbo.tbTeam", "Modality_Id", "dbo.tbModality");
            DropForeignKey("dbo.tbUser", "Team_Id", "dbo.tbTeam");
            DropForeignKey("dbo.tbTeam", "Horary_Id", "dbo.tbHorary");
            DropForeignKey("dbo.tbUser", "RoleID_Id", "dbo.tbRole");
            DropForeignKey("dbo.tbUser", "Role_Id", "dbo.tbRole");
            DropForeignKey("dbo.tbGymUserModality", "User_Id", "dbo.tbUser");
            DropForeignKey("dbo.tbUser", "AddressID_Id", "dbo.tbAdress");
            DropForeignKey("dbo.tbUser", "Address_Id", "dbo.tbAdress");
            DropForeignKey("dbo.tbTrainingRecord", "GymUserModality_Id", "dbo.tbGymUserModality");
            DropForeignKey("dbo.tbExercise", "TrainingRecord_Id", "dbo.tbTrainingRecord");
            DropForeignKey("dbo.tbGymUserModality", "Modality_Id", "dbo.tbModality");
            DropForeignKey("dbo.tbGymUserModality", "Gym_Id", "dbo.tbGym");
            DropForeignKey("dbo.tbModality", "Gym_Id", "dbo.tbGym");
            DropForeignKey("dbo.tbGym", "Address_Id", "dbo.tbAdress");
            DropForeignKey("dbo.tbExercise", "Category_Id", "dbo.tbCategory");
            DropForeignKey("dbo.tbAdress", "District_Id", "dbo.tbDistrict");
            DropForeignKey("dbo.tbDistrict", "City_Id", "dbo.tbCity");
            DropForeignKey("dbo.tbCity", "State_Id", "dbo.tbState");
            DropIndex("dbo.tbTraining", new[] { "Teacher_Id" });
            DropIndex("dbo.tbTeam", new[] { "Teacher_Id" });
            DropIndex("dbo.tbTeam", new[] { "ModalityID_Id" });
            DropIndex("dbo.tbTeam", new[] { "Modality_Id" });
            DropIndex("dbo.tbTeam", new[] { "Horary_Id" });
            DropIndex("dbo.tbUser", new[] { "Team_Id" });
            DropIndex("dbo.tbUser", new[] { "RoleID_Id" });
            DropIndex("dbo.tbUser", new[] { "Role_Id" });
            DropIndex("dbo.tbUser", new[] { "AddressID_Id" });
            DropIndex("dbo.tbUser", new[] { "Address_Id" });
            DropIndex("dbo.tbTrainingRecord", new[] { "Training_Id" });
            DropIndex("dbo.tbTrainingRecord", new[] { "GymUserModality_Id" });
            DropIndex("dbo.tbGymUserModality", new[] { "User_Id" });
            DropIndex("dbo.tbGymUserModality", new[] { "Modality_Id" });
            DropIndex("dbo.tbGymUserModality", new[] { "Gym_Id" });
            DropIndex("dbo.tbModality", new[] { "Gym_Id" });
            DropIndex("dbo.tbGym", new[] { "Address_Id" });
            DropIndex("dbo.tbExercise", new[] { "TrainingRecord_Id" });
            DropIndex("dbo.tbExercise", new[] { "Category_Id" });
            DropIndex("dbo.tbCity", new[] { "State_Id" });
            DropIndex("dbo.tbDistrict", new[] { "City_Id" });
            DropIndex("dbo.tbAdress", new[] { "District_Id" });
            DropTable("dbo.tbTraining");
            DropTable("dbo.tbTeam");
            DropTable("dbo.tbHorary");
            DropTable("dbo.tbRole");
            DropTable("dbo.tbUser");
            DropTable("dbo.tbTrainingRecord");
            DropTable("dbo.tbGymUserModality");
            DropTable("dbo.tbModality");
            DropTable("dbo.tbGym");
            DropTable("dbo.tbFrequency");
            DropTable("dbo.tbExercise");
            DropTable("dbo.tbCategory");
            DropTable("dbo.tbState");
            DropTable("dbo.tbCity");
            DropTable("dbo.tbDistrict");
            DropTable("dbo.tbAdress");
        }
    }
}
