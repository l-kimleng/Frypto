namespace Frypto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFlightScheduleModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FlightSchedules",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FlightNumber = c.String(),
                        AircraftType = c.String(),
                        OriginAirportId = c.Int(nullable: false),
                        DestinationAirportId = c.Int(nullable: false),
                        DepartureDateTime = c.DateTime(nullable: false),
                        ArrivalDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Airports", t => t.DestinationAirportId)
                .ForeignKey("dbo.Airports", t => t.OriginAirportId)
                .Index(t => t.OriginAirportId)
                .Index(t => t.DestinationAirportId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FlightSchedules", "OriginAirportId", "dbo.Airports");
            DropForeignKey("dbo.FlightSchedules", "DestinationAirportId", "dbo.Airports");
            DropIndex("dbo.FlightSchedules", new[] { "DestinationAirportId" });
            DropIndex("dbo.FlightSchedules", new[] { "OriginAirportId" });
            DropTable("dbo.FlightSchedules");
        }
    }
}
