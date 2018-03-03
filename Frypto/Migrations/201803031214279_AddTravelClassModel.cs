namespace Frypto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTravelClassModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TravelClasses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Class = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TravelClasses");
        }
    }
}
