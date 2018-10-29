namespace MasomeenTravels.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialized : DbMigration
    {
        public override void Up()
        {
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
        }
    }
}
