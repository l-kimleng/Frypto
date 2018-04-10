namespace Frypto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLegModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Legs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FlightNumber = c.String(),
                        OriginAirportId = c.Int(nullable: false),
                        DestinationAirportId = c.Int(nullable: false),
                        ActualDepartureTime = c.DateTime(nullable: false),
                        ActualArrivalTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Airports", t => t.DestinationAirportId)
                .ForeignKey("dbo.Airports", t => t.OriginAirportId)
                .Index(t => t.OriginAirportId)
                .Index(t => t.DestinationAirportId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Legs", "OriginAirportId", "dbo.Airports");
            DropForeignKey("dbo.Legs", "DestinationAirportId", "dbo.Airports");
            DropIndex("dbo.Legs", new[] { "DestinationAirportId" });
            DropIndex("dbo.Legs", new[] { "OriginAirportId" });
            DropTable("dbo.Legs");
        }
    }
}
