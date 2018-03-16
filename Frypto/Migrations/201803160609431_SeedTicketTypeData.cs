namespace Frypto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedTicketTypeData : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO TicketTypes(Name) VALUES('One Way');
            INSERT INTO TicketTypes(Name) VALUES('Return');
            INSERT INTO TicketTypes(Name) VALUES('Advanced');
            ");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM TicketTypes WHERE Name IN ('One Way', 'Return', 'Advanced')");
        }
    }
}
