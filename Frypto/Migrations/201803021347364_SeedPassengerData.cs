namespace Frypto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedPassengerData : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ('Ellyn', 'Halliburton', '805-628-9255', 'ehalliburton0@cmu.edu', '582 Lyons Park', 'Majiang', 'China');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ('Yehudi', 'Cheng', '980-292-4865', 'ycheng1@omniture.com', '12 Melrose Place', 'Novokubansk', 'Russia');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ('Corrie', 'Kasher', '863-927-1249', 'ckasher2@people.com.cn', '805 Sundown Park', 'Noisy-le-Grand', 'France');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ('Ardis', 'Lenard', '804-659-4232', 'alenard3@washington.edu', '47 Mesta Hill', 'Gumuk Tengah', 'Indonesia');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ('Jordon', 'Sanches', '473-961-2756', 'jsanches4@xinhuanet.com', '932 Eliot Alley', 'Tomsk', 'Russia');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ('Bendix', 'Willard', '316-347-0030', 'bwillard5@sciencedirect.com', '96603 Maywood Place', 'Agdzhabedy', 'Azerbaijan');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ('Rosanna', 'Herkess', '691-922-6892', 'rherkess6@nydailynews.com', '0187 Carpenter Terrace', 'Baocun', 'China');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ('Gina', 'Tailby', '487-689-3216', 'gtailby7@slideshare.net', '69184 Corben Crossing', 'Mahong', 'China');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ('Decca', 'Corradengo', '161-905-7558', 'dcorradengo8@earthlink.net', '46 Heffernan Hill', 'Zargarān', 'Afghanistan');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Junie', 'Bestwerthick', '422-832-3327', 'jbestwerthick9@discuz.net', '66 Vahlen Plaza', 'Nafada', 'Nigeria');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Pierson', 'Bakey', '456-605-1767', 'pbakeya@bravesites.com', '9531 Green Street', 'Ambilobe', 'Madagascar');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Cyb', 'Tidbold', '223-238-9410', 'ctidboldb@cornell.edu', '261 Sachtjen Alley', 'Skalat', 'Ukraine');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Kary', 'Mash', '847-287-4302', 'kmashc@unesco.org', '04807 Porter Way', 'Yanling', 'China');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Amalia', 'Pavlishchev', '496-644-2411', 'apavlishchevd@woothemes.com', '00120 Schiller Drive', 'Tumpukrenteng', 'Indonesia');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Lotty', 'Menci', '393-730-1204', 'lmencie@amazon.co.jp', '3 Talisman Alley', 'Khafizan', 'Afghanistan');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Duffy', 'Jerman', '115-161-5951', 'djermanf@jugem.jp', '92631 Rutledge Pass', 'Lashkar Gāh', 'Afghanistan');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Mort', 'Ghidotti', '663-791-6324', 'mghidottig@utexas.edu', '13 Towne Hill', 'Guizi', 'China');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Will', 'Vanyashkin', '318-126-9943', 'wvanyashkinh@rakuten.co.jp', '125 Maryland Court', 'Purificación', 'Colombia');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Dolf', 'Adamolli', '407-704-3244', 'dadamollii@fotki.com', '2969 Kipling Park', 'Orlando', 'United States');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Illa', 'Glossop', '809-760-9024', 'iglossopj@hc360.com', '013 Lake View Alley', 'Klatakan', 'Indonesia');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Carri', 'Bedenham', '991-199-3385', 'cbedenhamk@home.pl', '74084 Victoria Parkway', 'Getahovit', 'Armenia');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Myrwyn', 'Manhood', '679-450-3512', 'mmanhoodl@slate.com', '82814 Scott Point', 'El Pardo', 'Philippines');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Ruby', 'Brussell', '602-968-0533', 'rbrussellm@blogspot.com', '7 Buhler Place', 'Mocajuba', 'Brazil');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Marabel', 'Nottingham', '132-558-6772', 'mnottinghamn@cyberchimps.com', '5 Independence Parkway', 'Huangshagang', 'China');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Jamison', 'Cicchinelli', '991-635-8219', 'jcicchinellio@unesco.org', '5331 Victoria Place', 'Kiambu', 'Kenya');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Matti', 'Steinson', '900-760-1846', 'msteinsonp@angelfire.com', '4741 Magdeline Trail', 'Wanrongjiang', 'China');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Jorgan', 'Acome', '823-116-0556', 'jacomeq@weebly.com', '670 Westport Park', 'Subotica', 'Serbia');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Rey', 'Cattlow', '387-462-4404', 'rcattlowr@360.cn', '78 Anniversary Hill', 'Al Qarārah', 'Palestinian Territory');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Elvira', 'Tomasoni', '356-400-2003', 'etomasonis@about.me', '39 Fairfield Park', 'Boucinhas', 'Portugal');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Ambrosius', 'Dooler', '584-582-6429', 'adoolert@cnbc.com', '6 Mifflin Street', 'Ode', 'Nigeria');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Britney', 'Fielders', '110-139-0747', 'bfieldersu@reddit.com', '27178 Crownhardt Trail', 'Enskede', 'Sweden');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Windy', 'Connerry', '313-211-8186', 'wconnerryv@amazon.com', '753 Laurel Lane', 'Xiangshan', 'China');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Charity', 'Furmenger', '237-949-0569', 'cfurmengerw@fc2.com', '01005 Grover Trail', 'União dos Palmares', 'Brazil');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Ezri', 'Guyet', '678-891-2626', 'eguyetx@paypal.com', '80 Alpine Hill', 'Santa Rita do Sapucaí', 'Brazil');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Iorgos', 'Loughney', '366-989-0817', 'iloughneyy@instagram.com', '6794 Shoshone Hill', 'Amman', 'Jordan');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Minnie', 'Dowe', '792-342-4750', 'mdowez@dion.ne.jp', '5028 Loftsgordon Crossing', 'Spokoynaya', 'Russia');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Deerdre', 'Binch', '431-464-8628', 'dbinch10@freewebs.com', '52 Petterle Road', 'Ōami', 'Japan');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Olav', 'Meric', '821-439-2411', 'omeric11@meetup.com', '1220 Hauk Avenue', 'Thompson', 'Canada');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Nedda', 'McKean', '333-824-0040', 'nmckean12@cocolog-nifty.com', '9 Johnson Center', 'Xianning', 'China');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Thurstan', 'Bengoechea', '658-739-5059', 'tbengoechea13@moonfruit.com', '043 Mifflin Plaza', 'Tambaksari', 'Indonesia');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Sadella', 'Navan', '294-273-7705', 'snavan14@cyberchimps.com', '5 Dottie Avenue', 'Larvik', 'Norway');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Gabbey', 'Sawkins', '993-914-7529', 'gsawkins15@geocities.com', '0 Hollow Ridge Road', 'Idanha-a-Nova', 'Portugal');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Montgomery', 'De Andreis', '318-885-4411', 'mdeandreis16@guardian.co.uk', '624 Macpherson Center', 'Munggang', 'Indonesia');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Patrice', 'Shirtcliffe', '197-537-2914', 'pshirtcliffe17@usatoday.com', '9 Ridgeway Parkway', 'Jinkou', 'China');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Julienne', 'Prebble', '847-933-0089', 'jprebble18@google.com.au', '66 Rutledge Way', 'Nový Malín', 'Czech Republic');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Regina', 'Bontein', '711-611-6371', 'rbontein19@taobao.com', '1799 Lakewood Center', 'Hpa-an', 'Myanmar');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Ruddy', 'Shoubridge', '525-788-1245', 'rshoubridge1a@slideshare.net', '34135 Ruskin Way', 'Hexi', 'China');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Zulema', 'Stockton', '959-370-2650', 'zstockton1b@nasa.gov', '63 Northland Plaza', 'Villeneuve-sur-Lot', 'France');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Yancey', 'Cannop', '451-250-1247', 'ycannop1c@ca.gov', '212 Scofield Trail', 'Bộc Bố', 'Vietnam');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Virgil', 'Kimbrey', '258-181-5505', 'vkimbrey1d@instagram.com', '17625 Merchant Lane', 'Sabugo', 'Portugal');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Ina', 'Coonihan', '225-840-9432', 'icoonihan1e@zimbio.com', '2013 Packers Alley', 'Baton Rouge', 'United States');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Austin', 'Currao', '506-342-4577', 'acurrao1f@dmoz.org', '63627 Rigney Drive', 'Cetinje', 'Montenegro');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Teodora', 'Brawn', '760-407-4602', 'tbrawn1g@forbes.com', '27061 Dakota Pass', 'Várzea Alegre', 'Brazil');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Erhart', 'Kember', '235-926-3275', 'ekember1h@cornell.edu', '8624 Nova Avenue', 'Puerto Rico', 'Argentina');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Sharl', 'Werndly', '257-287-2632', 'swerndly1i@jimdo.com', '6 Morrow Drive', 'Huangji', 'China');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Vittoria', 'Duffill', '201-404-9825', 'vduffill1j@ucla.edu', '51 Canary Plaza', 'Nong Chik', 'Thailand');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Rey', 'Deem', '598-546-6126', 'rdeem1k@admin.ch', '77908 Toban Pass', 'Đắk Hà', 'Vietnam');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Jedd', 'Pistol', '373-134-2357', 'jpistol1l@drupal.org', '96 4th Avenue', 'Pindi Gheb', 'Pakistan');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Dulcy', 'Temporal', '214-455-7603', 'dtemporal1m@java.com', '8312 Dottie Circle', 'Jakartovice', 'Czech Republic');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Niki', 'Norvell', '681-976-3387', 'nnorvell1n@slate.com', '1 Moose Point', 'Mapalacsiao', 'Philippines');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Ichabod', 'Krelle', '269-872-9119', 'ikrelle1o@ucsd.edu', '21451 Hermina Road', 'Khān Yūnis', 'Palestinian Territory');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Clayborne', 'Rampage', '899-367-1261', 'crampage1p@xing.com', '060 Talisman Crossing', 'Mabusag', 'Philippines');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Laurie', 'Norster', '732-831-2037', 'lnorster1q@theguardian.com', '160 Basil Pass', 'Brodósqui', 'Brazil');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Velma', 'Zmitrovich', '556-958-8129', 'vzmitrovich1r@nature.com', '69722 West Avenue', 'Kertapura', 'Indonesia');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Perceval', 'Shoobridge', '208-927-9917', 'pshoobridge1s@kickstarter.com', '0 Southridge Center', 'Glamang', 'Philippines');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Keri', 'Stalman', '223-576-2533', 'kstalman1t@chron.com', '677 Glendale Circle', 'Benito Juarez', 'Mexico');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Nickie', 'Lintin', '766-203-2086', 'nlintin1u@unc.edu', '9 Westend Park', 'Cavalões', 'Portugal');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Grannie', 'Hodgins', '478-593-5566', 'ghodgins1v@msn.com', '6 1st Alley', 'Pomerode', 'Brazil');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Jessica', 'Winsborrow', '775-731-4549', 'jwinsborrow1w@booking.com', '89 Oak Valley Plaza', 'Holýšov', 'Czech Republic');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Derek', 'Papaccio', '957-997-7945', 'dpapaccio1x@woothemes.com', '01753 Dennis Hill', 'Ituberá', 'Brazil');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Blanch', 'Asmus', '949-560-6120', 'basmus1y@sogou.com', '403 Aberg Avenue', 'Mpophomeni', 'South Africa');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Humbert', 'Rollins', '732-877-9190', 'hrollins1z@wordpress.com', '6 Anhalt Plaza', 'Bayan Tuohai', 'China');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Andrey', 'Hewlings', '608-602-0668', 'ahewlings20@yelp.com', '6999 Morningstar Crossing', 'Hatava', 'Belarus');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Mitzi', 'Rosenstock', '368-980-9625', 'mrosenstock21@e-recht24.de', '82 Karstens Place', 'New Plymouth', 'New Zealand');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Reggis', 'Musselwhite', '139-850-7102', 'rmusselwhite22@ovh.net', '07650 Superior Lane', 'Seto', 'Japan');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Torr', 'Durning', '991-315-0665', 'tdurning23@sphinn.com', '53886 Londonderry Circle', 'Meixi', 'China');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Burton', 'Connow', '502-582-7806', 'bconnow24@de.vu', '11875 Dorton Avenue', 'Pasirlaja', 'Indonesia');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Herold', 'Demschke', '898-727-9735', 'hdemschke25@arizona.edu', '3252 Macpherson Pass', 'Duque de Caxias', 'Brazil');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Winthrop', 'Beaston', '704-818-8667', 'wbeaston26@unc.edu', '62374 Talmadge Road', 'Koryukivka', 'Ukraine');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Josie', 'Trosdall', '633-534-1296', 'jtrosdall27@plala.or.jp', '69173 Leroy Place', 'Pindangan Centro', 'Philippines');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Ingelbert', 'Woakes', '209-704-9255', 'iwoakes28@imdb.com', '828 Laurel Trail', 'Dasht-e Lati', 'Iran');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Sibeal', 'Vase', '740-363-2320', 'svase29@hhs.gov', '5122 Manitowish Lane', 'Hele', 'China');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Sloane', 'Stollsteiner', '417-759-1834', 'sstollsteiner2a@harvard.edu', '7681 Mccormick Street', 'Duqu', 'China');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Rozanne', 'Laugharne', '299-282-1114', 'rlaugharne2b@cpanel.net', '96 Annamark Center', 'Banjar Gunungpande', 'Indonesia');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Barton', 'Dedmam', '821-470-4299', 'bdedmam2c@amazon.de', '35316 Rowland Pass', 'Tashla', 'Russia');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Juditha', 'Asprey', '168-128-2927', 'jasprey2d@scientificamerican.com', '488 Schiller Road', 'Vilppula', 'Finland');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Elle', 'Dranfield', '277-133-6817', 'edranfield2e@seattletimes.com', '465 Village Green Road', 'Norrköping', 'Sweden');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Malissia', 'Ancketill', '213-874-9447', 'mancketill2f@usda.gov', '71 Manitowish Parkway', 'Kadusimbar', 'Indonesia');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Caterina', 'Dunbabin', '684-821-9924', 'cdunbabin2g@dailymail.co.uk', '27 Susan Pass', 'Pong', 'Thailand');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Meyer', 'Astley', '536-207-6162', 'mastley2h@nature.com', '57586 Sherman Park', 'Älvängen', 'Sweden');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Lotta', 'Danett', '645-133-8824', 'ldanett2i@ameblo.jp', '5485 Green Ridge Park', 'Arpajon', 'France');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Marquita', 'Howcroft', '819-603-9336', 'mhowcroft2j@bloglines.com', '7516 Huxley Place', 'Höganäs', 'Sweden');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Aigneis', 'Knuckles', '309-757-0772', 'aknuckles2k@godaddy.com', '1 Sommers Trail', 'Liudong', 'China');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Earle', 'Villar', '780-655-5246', 'evillar2l@boston.com', '1 Iowa Pass', 'Kotlyarevskaya', 'Russia');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Winthrop', 'MacCallister', '335-678-9230', 'wmaccallister2m@blinklist.com', '4 Katie Junction', 'Coulommiers', 'France');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Hamlin', 'Mustoe', '128-816-4605', 'hmustoe2n@cam.ac.uk', '3 Superior Junction', 'Örebro', 'Sweden');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Concordia', 'Blench', '716-297-5317', 'cblench2o@patch.com', '965 Lunder Parkway', 'Áno Merá', 'Greece');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Regina', 'Engledow', '265-995-5615', 'rengledow2p@51.la', '1 Hallows Plaza', 'Nāgarpur', 'Bangladesh');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Yolande', 'Rockcliff', '225-426-6438', 'yrockcliff2q@dagondesign.com', '6359 Westridge Plaza', 'Ribeira Seca', 'Portugal');
            INSERT INTO Passengers (FirstName, LastName, PhoneNumber, Email, Address, City, Country) VALUES ( 'Dominga', 'Hastwall', '284-746-3100', 'dhastwall2r@time.com', '19272 Clyde Gallagher Avenue', 'Marihatag', 'Philippines');

            
            ");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Passengers WHERE Id BETWEEN 1 AND 100");
        }
    }
}
