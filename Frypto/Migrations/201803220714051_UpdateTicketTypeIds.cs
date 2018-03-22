namespace Frypto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateTicketTypeIds : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                UPDATE ItineraryReservations SET TicketTypeId = 1 WHERE Id = 1;
                UPDATE ItineraryReservations SET TicketTypeId = 3 WHERE Id = 2;
                UPDATE ItineraryReservations SET TicketTypeId = 2 WHERE Id = 3;
                UPDATE ItineraryReservations SET TicketTypeId = 2 WHERE Id = 4;
                UPDATE ItineraryReservations SET TicketTypeId = 3 WHERE Id = 5;
                UPDATE ItineraryReservations SET TicketTypeId = 1 WHERE Id = 6;
            ");
        }
        
        public override void Down()
        {
            Sql(@"UPDATE ItineraryReservations SET TicketTypeId = NULL WHERE Id IN (1,2,3,4,5,6)");
        }
    }
}
