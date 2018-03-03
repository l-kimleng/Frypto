namespace Frypto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedTravelClassData : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO TravelClasses (Class) VALUES('Economy');
            INSERT INTO TravelClasses (Class) VALUES('Business');
            INSERT INTO TravelClasses (Class) VALUES('First');
            ");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM TravelClasses WHERE Id IN (1,2,3)");
        }
    }
}
