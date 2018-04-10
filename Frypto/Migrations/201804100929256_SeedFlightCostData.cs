namespace Frypto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedFlightCostData : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 142', '5/26/2018', 'Boeing 767-300', '2018-08-26 22:08:48', 898);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 484', '7/5/2018', 'Airbus A380-800', '2018-10-05 01:09:18', 624);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 436', '8/26/2018', 'Airbus A340-300', '2018-11-26 09:38:58', 940);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 135', '9/11/2018', 'Airbus A380-800', '2018-12-11 10:57:38', 655);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 143', '9/15/2018', 'Airbus A318', '2018-12-15 13:10:28', 698);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 211', '6/10/2018', 'Boeing 767-300', '2018-09-10 03:45:47', 529);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 559', '10/20/2018', 'Boeing 767-300', '2019-01-20 08:44:59', 910);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 149', '8/6/2018', 'Airbus A380-800', '2018-11-06 21:59:28', 785);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 143', '7/22/2018', 'Airbus A380-800', '2018-10-22 14:59:37', 737);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 559', '9/13/2018', 'Airbus A340-300', '2018-12-13 20:47:48', 523);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 552', '12/24/2018', 'Airbus A321', '2019-03-24 00:55:52', 646);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 126', '5/17/2018', 'Boeing 787-9', '2018-08-17 13:12:58', 520);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 410', '6/16/2018', 'Airbus A318', '2018-09-16 04:35:38', 788);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 135', '4/30/2018', 'Boeing 737-800', '2018-07-30 05:52:21', 922);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 480', '11/7/2018', 'Airbus A318', '2019-02-07 16:46:39', 702);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 552', '10/23/2018', 'Boeing 787-8', '2019-01-23 13:09:52', 591);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 417', '9/15/2018', 'Airbus A380-800', '2018-12-15 20:38:02', 739);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 149', '6/17/2018', 'Boeing 787-9', '2018-09-17 03:23:02', 707);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 417', '8/13/2018', 'Airbus A340-300', '2018-11-13 06:04:59', 938);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 152', '4/25/2018', 'Airbus A318', '2018-07-25 04:54:43', 932);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 152', '5/12/2018', 'Boeing 787-8', '2018-08-12 22:16:11', 630);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 431', '10/5/2018', 'Boeing 787-9', '2019-01-05 17:30:45', 525);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 567', '11/17/2018', 'Airbus A318', '2019-02-17 21:11:01', 919);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 229', '12/17/2018', 'Airbus A380-800', '2019-03-17 13:45:58', 786);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 431', '11/23/2018', 'Boeing 787-9', '2019-02-23 03:35:08', 658);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 152', '6/23/2018', 'Boeing 787-9', '2018-09-23 06:13:22', 670);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 149', '6/6/2018', 'Boeing 737-800', '2018-09-06 09:30:49', 731);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 567', '9/10/2018', 'Boeing 737-800', '2018-12-10 05:05:46', 931);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 412', '5/17/2018', 'Boeing 767-300', '2018-08-17 10:30:03', 778);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 480', '10/6/2018', 'Airbus A318', '2019-01-06 19:39:13', 937);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 552', '9/28/2018', 'Airbus A380-800', '2018-12-28 17:25:23', 573);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 170', '6/8/2018', 'Boeing 787-8', '2018-09-08 19:06:17', 896);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 135', '6/7/2018', 'Boeing 787-8', '2018-09-07 18:43:26', 808);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 152', '7/18/2018', 'Boeing 787-9', '2018-10-18 13:53:50', 810);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 679', '6/15/2018', 'Boeing 767-300', '2018-09-15 01:17:11', 515);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 185', '7/16/2018', 'Boeing 787-8', '2018-10-16 08:26:34', 746);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 484', '9/2/2018', 'Boeing 787-8', '2018-12-02 11:32:07', 545);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 135', '7/1/2018', 'Boeing 787-9', '2018-10-01 10:08:00', 582);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 480', '10/25/2018', 'Boeing 787-8', '2019-01-25 03:32:39', 994);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 170', '6/28/2018', 'Boeing 787-9', '2018-09-28 00:21:41', 663);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 556', '12/1/2018', 'Airbus A380-800', '2019-03-01 14:46:26', 721);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 436', '10/26/2018', 'Boeing 737-800', '2019-01-26 23:48:39', 624);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 135', '12/18/2018', 'Airbus A340-300', '2019-03-18 08:04:49', 755);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 142', '10/16/2018', 'Airbus A318', '2019-01-16 16:28:13', 750);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 567', '7/10/2018', 'Airbus A318', '2018-10-10 22:36:42', 749);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 484', '12/11/2018', 'Boeing 787-9', '2019-03-11 22:09:47', 963);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 135', '5/18/2018', 'Boeing 737-800', '2018-08-18 17:34:52', 560);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 567', '5/28/2018', 'Boeing 767-300', '2018-08-28 16:25:00', 883);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 559', '4/25/2018', 'Boeing 737-800', '2018-07-25 03:55:39', 788);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 682', '12/20/2018', 'Boeing 777-300ER', '2019-03-20 11:38:09', 692);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 185', '8/9/2018', 'Airbus A318', '2018-11-09 14:39:09', 878);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 152', '5/30/2018', 'Boeing 777-300ER', '2018-08-30 03:33:51', 574);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 480', '6/24/2018', 'Airbus A380-800', '2018-09-24 11:10:01', 531);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 170', '10/22/2018', 'Boeing 767-300', '2019-01-22 07:31:42', 577);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 552', '6/12/2018', 'Airbus A340-300', '2018-09-12 21:34:02', 674);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 679', '11/5/2018', 'Boeing 737-800', '2019-02-05 05:53:33', 765);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 559', '10/28/2018', 'Boeing 767-300', '2019-01-28 04:54:11', 878);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 143', '10/1/2018', 'Boeing 787-8', '2019-01-01 22:56:33', 714);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 556', '11/21/2018', 'Boeing 787-9', '2019-02-21 10:32:22', 957);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 688', '12/29/2018', 'Airbus A380-800', '2019-03-29 22:58:43', 957);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 168', '9/3/2018', 'Boeing 787-8', '2018-12-03 00:27:05', 775);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 613', '10/19/2018', 'Airbus A321', '2019-01-19 10:36:37', 551);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 229', '9/16/2018', 'Airbus A340-300', '2018-12-16 11:51:25', 858);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 436', '7/4/2018', 'Boeing 777-300ER', '2018-10-04 16:49:24', 590);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 142', '7/15/2018', 'Airbus A321', '2018-10-15 23:48:27', 787);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 436', '10/2/2018', 'Boeing 787-8', '2019-01-02 15:01:40', 872);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 211', '4/28/2018', 'Boeing 777-300ER', '2018-07-28 20:59:44', 674);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 168', '6/10/2018', 'Airbus A340-300', '2018-09-10 22:37:33', 846);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 559', '8/24/2018', 'Boeing 767-300', '2018-11-24 02:46:33', 797);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 142', '11/15/2018', 'Boeing 777-300ER', '2019-02-15 22:06:23', 880);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 412', '10/2/2018', 'Airbus A318', '2019-01-02 18:05:29', 905);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 484', '7/2/2018', 'Boeing 787-8', '2018-10-02 20:31:29', 596);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 410', '5/16/2018', 'Boeing 767-300', '2018-08-16 20:26:43', 881);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 412', '6/3/2018', 'Boeing 767-300', '2018-09-03 21:06:27', 740);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 436', '6/25/2018', 'Boeing 737-800', '2018-09-25 16:32:59', 755);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 185', '6/23/2018', 'Airbus A380-800', '2018-09-23 19:20:48', 881);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 613', '11/24/2018', 'Airbus A318', '2019-02-24 02:19:03', 646);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 168', '10/15/2018', 'Airbus A340-300', '2019-01-15 11:41:54', 732);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 552', '7/22/2018', 'Airbus A321', '2018-10-22 01:44:26', 560);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 168', '5/23/2018', 'Boeing 737-800', '2018-08-23 22:06:15', 860);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 152', '10/18/2018', 'Airbus A321', '2019-01-18 19:10:36', 586);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 143', '8/6/2018', 'Airbus A340-300', '2018-11-06 17:27:37', 560);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 229', '10/27/2018', 'Airbus A380-800', '2019-01-27 03:39:21', 723);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 613', '10/7/2018', 'Boeing 767-300', '2019-01-07 21:19:55', 556);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 552', '7/1/2018', 'Airbus A340-300', '2018-10-01 18:11:18', 680);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 135', '4/16/2018', 'Boeing 777-300ER', '2018-07-16 04:34:54', 586);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 480', '4/11/2018', 'Airbus A321', '2018-07-11 17:15:40', 632);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 604', '11/2/2018', 'Airbus A380-800', '2019-02-02 18:46:58', 550);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 143', '6/24/2018', 'Airbus A340-300', '2018-09-24 10:10:00', 913);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 185', '12/8/2018', 'Airbus A318', '2019-03-08 00:13:31', 713);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 431', '5/31/2018', 'Airbus A380-800', '2018-08-31 12:14:34', 707);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 567', '5/17/2018', 'Airbus A380-800', '2018-08-17 05:18:00', 820);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 664', '11/22/2018', 'Boeing 777-300ER', '2019-02-22 05:07:46', 569);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 135', '10/13/2018', 'Boeing 787-9', '2019-01-13 09:42:36', 800);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 168', '7/21/2018', 'Airbus A321', '2018-10-21 06:15:40', 706);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 126', '5/15/2018', 'Boeing 787-8', '2018-08-15 22:51:46', 580);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 431', '5/28/2018', 'Airbus A318', '2018-08-28 16:13:18', 621);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 688', '12/10/2018', 'Airbus A321', '2019-03-10 20:24:17', 539);
                INSERT INTO FlightCosts (FlightNumber, ValidFrom, AircraftType, ValidTo, Cost) VALUES ('EK 493', '11/13/2018', 'Boeing 787-8', '2019-02-13 07:06:26', 826);
            ");
        }
        
        public override void Down()
        {
            
        }
    }
}
