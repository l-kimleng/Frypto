namespace Frypto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedPaymentStatusData : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO PaymentStatus(Description) VALUES('Cancelled');
            INSERT INTO PaymentStatus(Description) VALUES('Completed');
            INSERT INTO PaymentStatus(Description) VALUES('Disputed');
            INSERT INTO PaymentStatus(Description) VALUES('Challenged');
            ");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM PaymentStatus WHERE Id IN (1,2,3,4)");
        }
    }
}
