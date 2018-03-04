namespace Frypto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedReservationData : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            SET IDENTITY_INSERT [dbo].[ItineraryReservations] ON
            INSERT INTO [dbo].[ItineraryReservations] ([Id], [AgentId], [PassengerId], [TravelClassId], [ReservationDate], [NumberInParty]) VALUES (1, 1, 1, 1, N'2018-01-02 00:00:00', 3)
            INSERT INTO [dbo].[ItineraryReservations] ([Id], [AgentId], [PassengerId], [TravelClassId], [ReservationDate], [NumberInParty]) VALUES (2, 1, 2, 2, N'2018-03-04 00:00:00', 2)
            INSERT INTO [dbo].[ItineraryReservations] ([Id], [AgentId], [PassengerId], [TravelClassId], [ReservationDate], [NumberInParty]) VALUES (3, 2, 3, 3, N'2018-03-02 00:00:00', 4)
            INSERT INTO [dbo].[ItineraryReservations] ([Id], [AgentId], [PassengerId], [TravelClassId], [ReservationDate], [NumberInParty]) VALUES (4, 1, 4, 2, N'2017-01-25 00:00:00', 1)
            INSERT INTO [dbo].[ItineraryReservations] ([Id], [AgentId], [PassengerId], [TravelClassId], [ReservationDate], [NumberInParty]) VALUES (5, 1, 4, 3, N'2017-01-25 00:00:00', 1)
            INSERT INTO [dbo].[ItineraryReservations] ([Id], [AgentId], [PassengerId], [TravelClassId], [ReservationDate], [NumberInParty]) VALUES (6, 4, 4, 3, N'2017-01-25 00:00:00', 1)
            SET IDENTITY_INSERT [dbo].[ItineraryReservations] OFF
            ");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM ItineraryReservations WHERE Id IN (1, 2, 3, 4, 5, 6)");
        }
    }
}
