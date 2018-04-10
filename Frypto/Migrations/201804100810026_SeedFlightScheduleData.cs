namespace Frypto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedFlightScheduleData : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 679', 'Airbus A321', 14, 12, '2018-09-15 08:41:55', '2018-09-16 22:41:55');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 559', 'Airbus A340-300', 9, 12, '2018-10-25 08:51:33', '2018-10-29 03:51:33');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 436', 'Airbus A380-800', 8, 8, '2018-09-06 23:38:12', '2018-09-09 06:38:12');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 126', 'Boeing 777-300ER', 4, 11, '2018-08-23 05:22:12', '2018-08-23 17:22:12');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 135', 'Boeing 777-300ER', 9, 6, '2018-08-08 17:51:07', '2018-08-12 01:51:07');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 567', 'Boeing 737-800', 5, 7, '2018-08-12 19:30:37', '2018-08-13 15:30:37');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 493', 'Boeing 777-300ER', 9, 10, '2018-10-03 00:27:53', '2018-10-03 02:27:53');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 142', 'Boeing 787-9', 3, 1, '2018-05-01 20:59:46', '2018-05-05 09:59:46');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 688', 'Airbus A340-300', 7, 2, '2018-06-25 15:34:59', '2018-06-27 00:34:59');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 567', 'Airbus A321', 8, 9, '2018-07-13 05:02:25', '2018-07-15 04:02:25');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 682', 'Airbus A380-800', 2, 10, '2018-09-08 16:30:53', '2018-09-12 13:30:53');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 604', 'Airbus A321', 14, 11, '2018-09-27 06:45:14', '2018-09-27 14:45:14');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 149', 'Airbus A318', 4, 4, '2018-09-16 17:45:26', '2018-09-19 12:45:26');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 480', 'Airbus A318', 14, 5, '2018-10-09 18:59:43', '2018-10-13 04:59:43');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 436', 'Boeing 777-300ER', 6, 10, '2018-06-21 13:52:52', '2018-06-24 00:52:52');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 559', 'Airbus A318', 3, 13, '2018-06-19 22:21:08', '2018-06-20 20:21:08');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 168', 'Airbus A321', 10, 14, '2018-08-13 08:21:12', '2018-08-15 18:21:12');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 126', 'Airbus A318', 5, 10, '2018-05-19 06:50:17', '2018-05-22 20:50:17');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 484', 'Boeing 787-9', 5, 6, '2018-09-12 11:19:43', '2018-09-15 14:19:43');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 149', 'Boeing 777-300ER', 12, 3, '2018-05-27 15:02:35', '2018-05-27 23:02:35');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 682', 'Airbus A380-800', 9, 14, '2018-07-31 08:08:02', '2018-08-02 23:08:02');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 664', 'Boeing 787-8', 7, 1, '2018-11-29 01:36:59', '2018-11-29 16:36:59');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 480', 'Airbus A321', 10, 10, '2018-06-29 14:13:22', '2018-07-02 17:13:22');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 431', 'Airbus A380-800', 12, 1, '2018-06-22 08:18:34', '2018-06-23 11:18:34');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 484', 'Boeing 787-8', 9, 14, '2018-08-14 20:29:54', '2018-08-16 23:29:54');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 168', 'Boeing 767-300', 8, 6, '2018-06-25 07:52:10', '2018-06-28 11:52:10');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 142', 'Airbus A340-300', 12, 11, '2018-05-07 23:23:16', '2018-05-08 02:23:16');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 152', 'Boeing 767-300', 5, 4, '2018-12-02 13:22:52', '2018-12-03 01:22:52');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 410', 'Airbus A340-300', 11, 15, '2018-12-13 09:25:42', '2018-12-14 04:25:42');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 682', 'Airbus A340-300', 15, 14, '2018-12-25 10:07:51', '2018-12-26 02:07:51');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 559', 'Airbus A321', 13, 15, '2018-07-20 00:19:34', '2018-07-21 15:19:34');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 664', 'Boeing 787-8', 3, 5, '2018-05-23 23:29:14', '2018-05-24 20:29:14');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 211', 'Airbus A321', 8, 7, '2018-11-23 15:31:10', '2018-11-23 21:31:10');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 664', 'Airbus A321', 12, 10, '2018-12-17 16:53:45', '2018-12-19 13:53:45');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 679', 'Boeing 737-800', 3, 8, '2018-09-15 00:48:26', '2018-09-16 23:48:26');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 552', 'Airbus A321', 8, 13, '2018-05-01 08:16:40', '2018-05-01 10:16:40');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 142', 'Airbus A318', 6, 7, '2018-07-21 20:08:38', '2018-07-25 19:08:38');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 559', 'Boeing 787-9', 2, 5, '2018-04-28 11:28:01', '2018-04-28 14:28:01');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 556', 'Airbus A321', 11, 13, '2018-07-15 21:25:09', '2018-07-16 07:25:09');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 604', 'Airbus A318', 8, 11, '2018-10-05 07:29:50', '2018-10-07 14:29:50');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 185', 'Airbus A318', 15, 13, '2018-06-10 23:56:27', '2018-06-14 19:56:27');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 229', 'Airbus A340-300', 4, 5, '2018-11-03 08:47:36', '2018-11-06 23:47:36');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 604', 'Boeing 777-300ER', 11, 8, '2018-06-23 00:12:55', '2018-06-26 03:12:55');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 556', 'Boeing 767-300', 3, 14, '2018-11-17 16:06:51', '2018-11-20 22:06:51');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 480', 'Airbus A321', 5, 5, '2018-10-06 20:13:51', '2018-10-09 15:13:51');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 152', 'Airbus A318', 1, 14, '2018-09-09 07:50:17', '2018-09-11 05:50:17');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 664', 'Boeing 777-300ER', 10, 4, '2018-11-29 12:39:29', '2018-11-30 11:39:29');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 152', 'Airbus A380-800', 5, 12, '2018-11-12 08:38:40', '2018-11-15 15:38:40');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 552', 'Airbus A321', 9, 5, '2018-08-25 19:38:16', '2018-08-27 06:38:16');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 436', 'Boeing 787-9', 10, 7, '2018-10-21 18:16:18', '2018-10-22 22:16:18');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 168', 'Airbus A380-800', 8, 5, '2018-08-25 11:58:51', '2018-08-29 03:58:51');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 613', 'Airbus A321', 3, 11, '2018-07-06 00:41:58', '2018-07-07 19:41:58');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 552', 'Boeing 777-300ER', 13, 14, '2018-11-13 14:43:28', '2018-11-16 07:43:28');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 664', 'Boeing 767-300', 11, 4, '2018-09-18 23:32:18', '2018-09-20 09:32:18');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 556', 'Airbus A321', 3, 3, '2018-05-19 10:22:51', '2018-05-22 18:22:51');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 567', 'Airbus A318', 12, 13, '2018-12-08 20:58:18', '2018-12-11 18:58:18');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 664', 'Boeing 787-9', 15, 4, '2018-11-17 20:36:13', '2018-11-19 22:36:13');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 152', 'Boeing 787-8', 1, 8, '2018-05-23 21:31:32', '2018-05-26 03:31:32');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 211', 'Airbus A318', 6, 13, '2018-09-22 23:42:05', '2018-09-26 13:42:05');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 567', 'Airbus A318', 5, 1, '2018-12-02 21:02:19', '2018-12-05 16:02:19');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 135', 'Boeing 787-8', 9, 8, '2018-07-20 02:52:30', '2018-07-21 23:52:30');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 604', 'Boeing 787-8', 14, 1, '2018-04-16 15:48:22', '2018-04-17 20:48:22');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 484', 'Airbus A318', 12, 5, '2018-11-06 21:42:49', '2018-11-09 07:42:49');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 552', 'Boeing 737-800', 14, 11, '2018-10-05 18:38:08', '2018-10-07 12:38:08');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 143', 'Boeing 787-9', 11, 9, '2018-07-17 07:59:34', '2018-07-21 01:59:34');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 185', 'Boeing 777-300ER', 8, 15, '2018-11-12 21:26:39', '2018-11-15 09:26:39');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 613', 'Boeing 767-300', 7, 10, '2018-09-27 01:04:18', '2018-10-01 00:04:18');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 417', 'Airbus A321', 3, 12, '2018-06-27 13:37:18', '2018-06-27 15:37:18');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 417', 'Boeing 777-300ER', 9, 11, '2018-09-22 11:19:16', '2018-09-23 01:19:16');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 170', 'Boeing 767-300', 8, 2, '2018-06-27 12:33:15', '2018-07-01 02:33:15');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 149', 'Airbus A380-800', 15, 1, '2018-09-15 09:54:02', '2018-09-15 23:54:02');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 152', 'Boeing 767-300', 8, 15, '2018-06-03 04:20:47', '2018-06-03 09:20:47');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 142', 'Airbus A380-800', 12, 12, '2018-12-29 12:04:57', '2018-12-29 13:04:57');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 211', 'Boeing 737-800', 6, 3, '2018-08-03 10:59:25', '2018-08-06 04:59:25');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 559', 'Airbus A321', 9, 9, '2018-06-27 23:03:38', '2018-06-29 09:03:38');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 152', 'Boeing 777-300ER', 14, 9, '2018-09-08 00:31:04', '2018-09-10 17:31:04');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 480', 'Airbus A380-800', 8, 1, '2018-04-22 16:23:33', '2018-04-23 15:23:33');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 664', 'Boeing 737-800', 9, 14, '2018-10-15 00:21:41', '2018-10-18 12:21:41');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 493', 'Boeing 777-300ER', 4, 15, '2018-11-21 15:36:14', '2018-11-23 23:36:14');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 143', 'Airbus A380-800', 14, 4, '2018-08-03 08:32:37', '2018-08-04 20:32:37');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 412', 'Boeing 787-8', 3, 10, '2018-12-17 05:37:55', '2018-12-18 09:37:55');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 168', 'Boeing 787-8', 3, 12, '2018-10-06 12:03:57', '2018-10-10 11:03:57');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 480', 'Boeing 787-8', 4, 15, '2018-09-06 06:22:39', '2018-09-09 12:22:39');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 436', 'Boeing 737-800', 14, 2, '2018-04-15 19:38:03', '2018-04-19 01:38:03');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 142', 'Airbus A321', 15, 3, '2018-07-06 06:09:55', '2018-07-09 07:09:55');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 559', 'Boeing 787-8', 10, 14, '2018-12-24 03:01:26', '2018-12-26 11:01:26');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 168', 'Airbus A321', 4, 1, '2018-12-17 13:59:08', '2018-12-20 07:59:08');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 679', 'Boeing 777-300ER', 7, 1, '2018-06-16 10:16:54', '2018-06-18 11:16:54');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 417', 'Boeing 787-8', 11, 10, '2018-06-21 18:40:23', '2018-06-23 08:40:23');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 436', 'Boeing 777-300ER', 2, 2, '2018-09-29 05:39:25', '2018-09-30 04:39:25');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 149', 'Airbus A380-800', 7, 15, '2018-04-17 01:23:52', '2018-04-19 17:23:52');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 417', 'Airbus A321', 9, 11, '2018-11-22 11:03:45', '2018-11-24 04:03:45');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 152', 'Boeing 787-9', 2, 9, '2018-09-24 22:26:10', '2018-09-26 09:26:10');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 604', 'Boeing 737-800', 4, 15, '2018-11-06 08:23:51', '2018-11-06 16:23:51');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 417', 'Boeing 787-9', 7, 3, '2018-08-24 10:31:58', '2018-08-26 14:31:58');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 143', 'Airbus A321', 8, 9, '2018-05-04 12:46:15', '2018-05-07 06:46:15');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 142', 'Boeing 737-800', 8, 14, '2018-05-24 14:14:45', '2018-05-25 19:14:45');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 613', 'Airbus A321', 7, 13, '2018-10-27 14:42:43', '2018-10-29 05:42:43');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 567', 'Boeing 787-8', 8, 2, '2018-10-07 12:16:48', '2018-10-09 11:16:48');
                INSERT INTO FlightSchedules (FlightNumber, AircraftType, OriginAirportId, DestinationAirportId, DepartureDateTime, ArrivalDateTime) VALUES ('EK 613', 'Airbus A380-800', 12, 15, '2018-08-20 01:25:18', '2018-08-21 02:25:18');
            ");
        }
        
        public override void Down()
        {
            Sql(@"
                DELETE FROM FlightSchedules WHERE Id BETWEEN 1 AND 100;    
            ");
        }
    }
}
