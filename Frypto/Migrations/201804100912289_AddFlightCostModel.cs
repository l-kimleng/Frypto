namespace Frypto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFlightCostModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FlightCosts",
                c => new
                    {
                        FlightNumber = c.String(nullable: false, maxLength: 128),
                        ValidFrom = c.DateTime(nullable: false),
                        AircraftType = c.String(),
                        ValidTo = c.DateTime(nullable: false),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => new { t.FlightNumber, t.ValidFrom });
            
        }
        
        public override void Down()
        {
            DropTable("dbo.FlightCosts");
        }
    }
}
