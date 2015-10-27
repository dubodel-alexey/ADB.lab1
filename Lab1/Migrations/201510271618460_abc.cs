namespace Lab1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class abc : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClientModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 100),
                        LastName = c.String(nullable: false, maxLength: 100),
                        Birthdate = c.DateTime(nullable: false),
                        GenderId = c.Int(nullable: false),
                        Gender = c.String(),
                        PassportSerie = c.String(nullable: false),
                        PassportNumber = c.String(nullable: false),
                        PassportIssuingAuthority = c.String(nullable: false, maxLength: 100),
                        IssueDate = c.DateTime(nullable: false),
                        IndentityNo = c.String(nullable: false),
                        LocationCityId = c.Int(nullable: false),
                        LocationCity = c.String(),
                        LocationAddress = c.String(nullable: false, maxLength: 100),
                        MobilePhoneNumber = c.String(),
                        Email = c.String(maxLength: 100),
                        Job = c.String(maxLength: 100),
                        JobPosition = c.String(maxLength: 100),
                        RegistrationCityId = c.Int(nullable: false),
                        RegistrationCity = c.String(),
                        RegistrationAddress = c.String(nullable: false, maxLength: 100),
                        MaritalStatusId = c.Int(nullable: false),
                        MaritalStatus = c.String(),
                        NationalityId = c.Int(nullable: false),
                        Nationality = c.String(),
                        DisabilityId = c.Int(nullable: false),
                        Disability = c.String(),
                        Pensioner = c.Boolean(nullable: false),
                        MonthlyIncome = c.Decimal(precision: 18, scale: 2),
                        Liable = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ClientModels");
        }
    }
}
