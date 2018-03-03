namespace Frypto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddItineraryReservationModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ItineraryReservations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AgentId = c.Int(nullable: false),
                        PassengerId = c.Int(nullable: false),
                        TravelClassId = c.Int(nullable: false),
                        ReservationDate = c.DateTime(nullable: false),
                        NumberInParty = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Agents", t => t.AgentId, cascadeDelete: true)
                .ForeignKey("dbo.Passengers", t => t.PassengerId, cascadeDelete: true)
                .ForeignKey("dbo.TravelClasses", t => t.TravelClassId, cascadeDelete: true)
                .Index(t => t.AgentId)
                .Index(t => t.PassengerId)
                .Index(t => t.TravelClassId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ItineraryReservations", "TravelClassId", "dbo.TravelClasses");
            DropForeignKey("dbo.ItineraryReservations", "PassengerId", "dbo.Passengers");
            DropForeignKey("dbo.ItineraryReservations", "AgentId", "dbo.Agents");
            DropIndex("dbo.ItineraryReservations", new[] { "TravelClassId" });
            DropIndex("dbo.ItineraryReservations", new[] { "PassengerId" });
            DropIndex("dbo.ItineraryReservations", new[] { "AgentId" });
            DropTable("dbo.ItineraryReservations");
        }
    }
}
