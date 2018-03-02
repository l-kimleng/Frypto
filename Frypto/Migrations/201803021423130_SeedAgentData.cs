namespace Frypto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedAgentData : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO Agents (Name, Description) VALUES ('Dicki-Wintheiser', 'nec sem duis aliquam convallis nunc proin at turpis a pede posuere nonummy');
            INSERT INTO Agents (Name, Description) VALUES ('Gulgowski, Schmitt and Wyman', 'pulvinar nulla pede ullamcorper augue a suscipit nulla elit ac nulla sed');
            INSERT INTO Agents (Name, Description) VALUES ('Kihn, McCullough and Eichmann', 'nisi vulputate nonummy maecenas tincidunt lacus at velit vivamus vel');
            INSERT INTO Agents (Name, Description) VALUES ('Stanton and Sons', 'erat id mauris vulputate elementum nullam varius nulla facilisi cras non velit nec nisi vulputate nonummy maecenas');
            INSERT INTO Agents (Name, Description) VALUES ('Schimmel-Kertzmann', 'maecenas ut massa quis augue luctus tincidunt nulla mollis molestie lorem quisque');
            ");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Agents WHERE Id IN (1,2,3,4,5)");
        }
    }
}
