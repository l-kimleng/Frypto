namespace Frypto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddReservationPaymentModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ReservationPayments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ReservationId = c.Int(nullable: false),
                        PaymentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Payments", t => t.PaymentId, cascadeDelete: true)
                .ForeignKey("dbo.ItineraryReservations", t => t.ReservationId, cascadeDelete: true)
                .Index(t => t.ReservationId)
                .Index(t => t.PaymentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ReservationPayments", "ReservationId", "dbo.ItineraryReservations");
            DropForeignKey("dbo.ReservationPayments", "PaymentId", "dbo.Payments");
            DropIndex("dbo.ReservationPayments", new[] { "PaymentId" });
            DropIndex("dbo.ReservationPayments", new[] { "ReservationId" });
            DropTable("dbo.ReservationPayments");
        }
    }
}
