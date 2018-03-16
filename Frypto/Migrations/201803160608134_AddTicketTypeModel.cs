namespace Frypto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTicketTypeModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TicketTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.ItineraryReservations", "TicketTypeId", c => c.Int());
            CreateIndex("dbo.ItineraryReservations", "TicketTypeId");
            AddForeignKey("dbo.ItineraryReservations", "TicketTypeId", "dbo.TicketTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ItineraryReservations", "TicketTypeId", "dbo.TicketTypes");
            DropIndex("dbo.ItineraryReservations", new[] { "TicketTypeId" });
            DropColumn("dbo.ItineraryReservations", "TicketTypeId");
            DropTable("dbo.TicketTypes");
        }
    }
}
