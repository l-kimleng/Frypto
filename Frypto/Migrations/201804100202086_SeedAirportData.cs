namespace Frypto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedAirportData : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO Airports(Code, Name, Location, Description) VALUES('AAL', 'Aalborg', 'Ny Lufthavnsvej 100, 9400 Nørresundby, Denmark', '3.5 NM northwest of Aalborg.');  
            INSERT INTO Airports(Code, Name, Location, Description) VALUES('AES', 'Aalesund', 'Flyplassvegen 27, 6040 Vigra, Norway', 'Vigra is an international airport serving the town of Ålesund, Norway.'); 
            INSERT INTO Airports(Code, Name, Location, Description) VALUES('ABA', 'Abakan Airport', 'Abakan, Republic of Khakassia, Russia', 'It is the only airport in the region (Khakassia and south of Krasnoyarsk Kray) suitable for all types of aircraft.');
            INSERT INTO Airports(Code, Name, Location, Description) VALUES('ADL', 'Adelaide', '1 James Schofield Dr, Adelaide Airport SA 5950, Australia', 'Adelaide Airport is the principal airport of Adelaide, South Australia and the fifth busiest airport in Australia, servicing just over eight million passengers in the financial year ending 30 June 2017.');
            INSERT INTO Airports(Code, Name, Location, Description) VALUES('BNK', 'Ballina', '210 Southern Cross Dr, Ballina NSW 2478, Australia', 'It serves Ballina and the nearby town of Byron Bay, a 20-minute drive north.');
            INSERT INTO Airports(Code, Name, Location, Description) VALUES('PNH', 'Phnom Penh', '2000 Angkor Phnom Penh St, Phnom Penh', 'Phnom Penh International Airport, is the busiest airport in terms of passenger movements and largest airport in Cambodia.');
            INSERT INTO Airports(Code, Name, Location, Description) VALUES('PEK', 'Beijing', 'Shunyi, Beijing, China', 'It is located 32 km northeast of Beijing city center, in an enclave of Chaoyang District and the surroundings of that enclave in suburban Shunyi District.');
            INSERT INTO Airports(Code, Name, Location, Description) VALUES('BKK', 'Bangkok', '999 1 Nong Prue, Amphoe Bang Phli, Chang Wat Samut Prakan 10540, Thailand', 'Suvarnabhumi Airport, also known unofficially as Bangkok Airport, is one of two international airports serving Bangkok, Thailand.');
            INSERT INTO Airports(Code, Name, Location, Description) VALUES('CEK', 'Chelyabinsk', 'Balandino, Chelyabinsk Oblast, Russia, 454133', 'It services large airliners and can park up to 51 aircraft. It also serves as a secondary hub for Ural Airlines and Yamal Airlines.');
            INSERT INTO Airports(Code, Name, Location, Description) VALUES('DXB', 'Dubai', 'Dubai - United Arab Emirates', 'Dubai International Airport is the primary international airport serving Dubai, United Arab Emirates and is the world busiest airport by international passenger traffic.');
            INSERT INTO Airports(Code, Name, Location, Description) VALUES('ADZ', 'San Andres Airport', 'Av Colon, San Andrés, Colombia', 'Gustavo Rojas Pinilla International Airport is the main airport in the archipelago of San Andrés, Providencia and Santa Catalina, one of the departments of Colombia.');
            INSERT INTO Airports(Code, Name, Location, Description) VALUES('NRT', 'Tokyo Narita', '1-1 Furugome, Narita, Chiba Prefecture 282-0004, Japan', 'Narita International Airport, also known as Tokyo Narita Airport, formerly and originally known as New Tokyo International Airport, is an international airport serving the Greater Tokyo Area of Japan.');
            INSERT INTO Airports(Code, Name, Location, Description) VALUES('JFK', 'John F. Kennedy International Airport', 'Queens, NY 11430, USA', 'John F. Kennedy International Airport is the primary international airport serving New York City.');
            INSERT INTO Airports(Code, Name, Location, Description) VALUES('BOS', 'Logan International Airport', '1 Harborside Dr, Boston, MA 02128, USA', 'Logan International Airport, officially known as General Edward Lawrence Logan International Airport, is an international airport in the East Boston neighborhood of Boston, Massachusetts, United States.');
            INSERT INTO Airports(Code, Name, Location, Description) VALUES('FLR', 'Florence', 'Via del Termine, 11, 50127 Firenze FI, Italy', 'Florence Airport, Peretola, Italian Aeroporto di Firenze-Peretola and formally Amerigo Vespucci Airport, is the international airport of Florence, the capital of the Italian region of Tuscany.');
            ");
        }
        
        public override void Down()
        {
            Sql(@"DELETE FROM Airports WHERE Code IN ('AAL', 'AES', 'ABA', 'ADL', 'BNK', 'PNH', 'PEK', 'BKK',
                'CEK', 'DXB', 'ADZ', 'NRT', 'JFK', 'BOS', 'FLR')

            ");
        }
    }
}
