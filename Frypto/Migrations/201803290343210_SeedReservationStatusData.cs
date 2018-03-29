namespace Frypto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedReservationStatusData : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO ReservationStatus(Label) VALUES ('Pending'); 
                INSERT INTO ReservationStatus(Label) VALUES ('Cancel'); 
                INSERT INTO ReservationStatus(Label) VALUES ('Paid'); 
            ");


            Sql(@"
                UPDATE ItineraryReservations SET ReservationStatusId = 1 WHERE Id = 1;
                UPDATE ItineraryReservations SET ReservationStatusId = 1 WHERE Id = 2;
                UPDATE ItineraryReservations SET ReservationStatusId = 2 WHERE Id = 3;
                UPDATE ItineraryReservations SET ReservationStatusId = 3 WHERE Id = 4;
                UPDATE ItineraryReservations SET ReservationStatusId = 3 WHERE Id = 5;
                UPDATE ItineraryReservations SET ReservationStatusId = 3 WHERE Id = 6;
            ");
        }
        
        public override void Down()
        {
            Sql(@" 
                UPDATE ItineraryReservations SET ReservationStatusId = NULL WHERE Id IN (1,2,3,4,5,6); 
                DELETE ReservationStatus WHERE Id IN (1,2,3);
            ");
        }
    }
}
