namespace MasomeenTravels.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initiliazed : DbMigration
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
            
            CreateTable(
                "dbo.MainSliders",
                c => new
                    {
                        SliderID = c.Int(nullable: false, identity: true),
                        Caption1 = c.String(),
                        Caption2 = c.String(),
                        Image = c.String(),
                        AltText = c.String(),
                        Description = c.String(),
                        ButtonText1 = c.String(),
                        ButtonText2 = c.String(),
                    })
                .PrimaryKey(t => t.SliderID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MainSliders");
            DropTable("dbo.CompanyInfoes");
        }
    }
}
