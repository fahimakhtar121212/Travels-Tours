namespace MasomeenTravels.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _new : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CompanyInfoes",
                c => new
                    {
                        AboutCompanyID = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(),
                        CompanyLogo = c.String(),
                        Description = c.String(),
                        CompanyVision = c.String(),
                        Established = c.String(),
                        Address = c.String(),
                        EmailAddress = c.String(),
                        Mobile = c.String(),
                        LandLine = c.String(),
                        Fax = c.String(),
                        LocationMap = c.String(),
                    })
                .PrimaryKey(t => t.AboutCompanyID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CompanyInfoes");
        }
    }
}
