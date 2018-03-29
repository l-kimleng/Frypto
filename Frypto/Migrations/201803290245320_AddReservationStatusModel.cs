namespace Frypto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddReservationStatusModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ReservationStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Label = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.ItineraryReservations", "ReservationStatusId", c => c.Int());
            CreateIndex("dbo.ItineraryReservations", "ReservationStatusId");
            AddForeignKey("dbo.ItineraryReservations", "ReservationStatusId", "dbo.ReservationStatus", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ItineraryReservations", "ReservationStatusId", "dbo.ReservationStatus");
            DropIndex("dbo.ItineraryReservations", new[] { "ReservationStatusId" });
            DropColumn("dbo.ItineraryReservations", "ReservationStatusId");
            DropTable("dbo.ReservationStatus");
        }
    }
}
