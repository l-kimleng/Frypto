namespace Frypto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedLegData : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO Legs (FlightNumber, OriginAirportId, DestinationAirportId, ActualDepartureTime, ActualArrivalTime) VALUES ('EK 552', 10, 4, '14:39', '21:46');
                INSERT INTO Legs (FlightNumber, OriginAirportId, DestinationAirportId, ActualDepartureTime, ActualArrivalTime) VALUES ('EK 484', 10, 8, '23:15', '22:04');
                INSERT INTO Legs (FlightNumber, OriginAirportId, DestinationAirportId, ActualDepartureTime, ActualArrivalTime) VALUES ('EK 493', 6, 8, '2:44', '0:12');
                INSERT INTO Legs (FlightNumber, OriginAirportId, DestinationAirportId, ActualDepartureTime, ActualArrivalTime) VALUES ('EK 126', 7, 4, '6:40', '20:29');
                INSERT INTO Legs (FlightNumber, OriginAirportId, DestinationAirportId, ActualDepartureTime, ActualArrivalTime) VALUES ('EK 170', 10, 13, '13:27', '4:32');
                INSERT INTO Legs (FlightNumber, OriginAirportId, DestinationAirportId, ActualDepartureTime, ActualArrivalTime) VALUES ('EK 556', 6, 8, '19:01', '17:00');
                INSERT INTO Legs (FlightNumber, OriginAirportId, DestinationAirportId, ActualDepartureTime, ActualArrivalTime) VALUES ('EK 142', 8, 12, '10:26', '23:46');
                INSERT INTO Legs (FlightNumber, OriginAirportId, DestinationAirportId, ActualDepartureTime, ActualArrivalTime) VALUES ('EK 168', 12, 1, '14:21', '1:17');
                INSERT INTO Legs (FlightNumber, OriginAirportId, DestinationAirportId, ActualDepartureTime, ActualArrivalTime) VALUES ('EK 417', 7, 14, '6:29', '10:14');
                INSERT INTO Legs (FlightNumber, OriginAirportId, DestinationAirportId, ActualDepartureTime, ActualArrivalTime) VALUES ('EK 135', 7, 1, '23:23', '10:38');
                INSERT INTO Legs (FlightNumber, OriginAirportId, DestinationAirportId, ActualDepartureTime, ActualArrivalTime) VALUES ('EK 229', 13, 3, '23:17', '1:08');
                INSERT INTO Legs (FlightNumber, OriginAirportId, DestinationAirportId, ActualDepartureTime, ActualArrivalTime) VALUES ('EK 664', 6, 4, '17:40', '4:58');
                INSERT INTO Legs (FlightNumber, OriginAirportId, DestinationAirportId, ActualDepartureTime, ActualArrivalTime) VALUES ('EK 436', 9, 4, '7:06', '2:38');
                INSERT INTO Legs (FlightNumber, OriginAirportId, DestinationAirportId, ActualDepartureTime, ActualArrivalTime) VALUES ('EK 412', 4, 3, '12:45', '19:05');
                INSERT INTO Legs (FlightNumber, OriginAirportId, DestinationAirportId, ActualDepartureTime, ActualArrivalTime) VALUES ('EK 567', 3, 3, '23:22', '23:02');
                INSERT INTO Legs (FlightNumber, OriginAirportId, DestinationAirportId, ActualDepartureTime, ActualArrivalTime) VALUES ('EK 410', 5, 15, '22:14', '22:41');
                INSERT INTO Legs (FlightNumber, OriginAirportId, DestinationAirportId, ActualDepartureTime, ActualArrivalTime) VALUES ('EK 559', 3, 10, '19:17', '14:24');
                INSERT INTO Legs (FlightNumber, OriginAirportId, DestinationAirportId, ActualDepartureTime, ActualArrivalTime) VALUES ('EK 211', 2, 5, '2:06', '10:42');
                INSERT INTO Legs (FlightNumber, OriginAirportId, DestinationAirportId, ActualDepartureTime, ActualArrivalTime) VALUES ('EK 604', 10, 15, '8:15', '5:37');
                INSERT INTO Legs (FlightNumber, OriginAirportId, DestinationAirportId, ActualDepartureTime, ActualArrivalTime) VALUES ('EK 613', 6, 14, '19:52', '20:07');
                INSERT INTO Legs (FlightNumber, OriginAirportId, DestinationAirportId, ActualDepartureTime, ActualArrivalTime) VALUES ('EK 431', 12, 11, '14:02', '9:14');
                INSERT INTO Legs (FlightNumber, OriginAirportId, DestinationAirportId, ActualDepartureTime, ActualArrivalTime) VALUES ('EK 480', 9, 12, '0:44', '14:13');
                INSERT INTO Legs (FlightNumber, OriginAirportId, DestinationAirportId, ActualDepartureTime, ActualArrivalTime) VALUES ('EK 688', 13, 6, '14:53', '20:38');
                INSERT INTO Legs (FlightNumber, OriginAirportId, DestinationAirportId, ActualDepartureTime, ActualArrivalTime) VALUES ('EK 679', 12, 3, '8:44', '23:44');
                INSERT INTO Legs (FlightNumber, OriginAirportId, DestinationAirportId, ActualDepartureTime, ActualArrivalTime) VALUES ('EK 152', 13, 11, '20:50', '13:57');
                INSERT INTO Legs (FlightNumber, OriginAirportId, DestinationAirportId, ActualDepartureTime, ActualArrivalTime) VALUES ('EK 480', 10, 10, '12:55', '13:54');
                INSERT INTO Legs (FlightNumber, OriginAirportId, DestinationAirportId, ActualDepartureTime, ActualArrivalTime) VALUES ('EK 149', 7, 3, '14:13', '10:42');
                INSERT INTO Legs (FlightNumber, OriginAirportId, DestinationAirportId, ActualDepartureTime, ActualArrivalTime) VALUES ('EK 682', 11, 14, '16:56', '15:53');
                INSERT INTO Legs (FlightNumber, OriginAirportId, DestinationAirportId, ActualDepartureTime, ActualArrivalTime) VALUES ('EK 185', 14, 3, '15:20', '16:32');
                INSERT INTO Legs (FlightNumber, OriginAirportId, DestinationAirportId, ActualDepartureTime, ActualArrivalTime) VALUES ('EK 143', 12, 10, '18:06', '8:34');
            ");
        }
        
        public override void Down()
        {
            Sql(@"
                DELETE FROM Legs WHERE Id BETWEEN 1 AND 30;
            ");
        }
    }
}
