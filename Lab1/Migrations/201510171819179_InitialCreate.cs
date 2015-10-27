namespace Lab1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 100),
                        LastName = c.String(nullable: false, maxLength: 100),
                        Birthdate = c.DateTime(nullable: false),
                        GenderId = c.Int(nullable: false),
                        PassportSerie = c.String(nullable: false, maxLength: 2),
                        PassportNumber = c.String(nullable: false, maxLength: 7),
                        PassportIssuingAuthority = c.String(nullable: false, maxLength: 100),
                        IssueDate = c.DateTime(nullable: false),
                        IndentityNo = c.String(nullable: false, maxLength: 14),
                        LocationCityId = c.Int(nullable: false),
                        LocationAddress = c.String(nullable: false, maxLength: 100),
                        MobilePhoneNumber = c.String(maxLength: 11),
                        Email = c.String(maxLength: 100),
                        Work = c.String(maxLength: 100),
                        JobPosition = c.String(maxLength: 100),
                        RegistrationCityId = c.Int(nullable: false),
                        RegistrationAddress = c.String(nullable: false, maxLength: 100),
                        MaritalStatusId = c.Int(nullable: false),
                        NationalityId = c.Int(nullable: false),
                        DisabilityId = c.Int(nullable: false),
                        Pensioner = c.Boolean(nullable: false),
                        MonthlyIncome = c.Decimal(precision: 18, scale: 2),
                        Liable = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Disabilities", t => t.DisabilityId)
                .ForeignKey("dbo.Genders", t => t.GenderId)
                .ForeignKey("dbo.Cities", t => t.LocationCityId, cascadeDelete: true)
                .ForeignKey("dbo.MaritalStatus", t => t.MaritalStatusId)
                .ForeignKey("dbo.Nationalities", t => t.NationalityId)
                .ForeignKey("dbo.Cities", t => t.RegistrationCityId)
                .Index(t => t.GenderId)
                .Index(t => t.LocationCityId)
                .Index(t => t.RegistrationCityId)
                .Index(t => t.MaritalStatusId)
                .Index(t => t.NationalityId)
                .Index(t => t.DisabilityId);
            
            CreateTable(
                "dbo.Disabilities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Genders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MaritalStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Nationalities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clients", "RegistrationCityId", "dbo.Cities");
            DropForeignKey("dbo.Clients", "NationalityId", "dbo.Nationalities");
            DropForeignKey("dbo.Clients", "MaritalStatusId", "dbo.MaritalStatus");
            DropForeignKey("dbo.Clients", "LocationCityId", "dbo.Cities");
            DropForeignKey("dbo.Clients", "GenderId", "dbo.Genders");
            DropForeignKey("dbo.Clients", "DisabilityId", "dbo.Disabilities");
            DropIndex("dbo.Clients", new[] { "DisabilityId" });
            DropIndex("dbo.Clients", new[] { "NationalityId" });
            DropIndex("dbo.Clients", new[] { "MaritalStatusId" });
            DropIndex("dbo.Clients", new[] { "RegistrationCityId" });
            DropIndex("dbo.Clients", new[] { "LocationCityId" });
            DropIndex("dbo.Clients", new[] { "GenderId" });
            DropTable("dbo.Nationalities");
            DropTable("dbo.MaritalStatus");
            DropTable("dbo.Genders");
            DropTable("dbo.Disabilities");
            DropTable("dbo.Clients");
            DropTable("dbo.Cities");
        }
    }
}
