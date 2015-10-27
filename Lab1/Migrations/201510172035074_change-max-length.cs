namespace Lab1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changemaxlength : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clients", "MobilePhoneNumber", c => c.String(maxLength: 12));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clients", "MobilePhoneNumber", c => c.String(maxLength: 11));
        }
    }
}
