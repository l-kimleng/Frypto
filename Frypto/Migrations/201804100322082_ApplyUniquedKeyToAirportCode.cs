namespace Frypto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyUniquedKeyToAirportCode : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Airports", "Code", c => c.String(maxLength: 10));
            CreateIndex("dbo.Airports", "Code", unique: true, name: "IX_AirportCode");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Airports", "IX_AirportCode");
            AlterColumn("dbo.Airports", "Code", c => c.String());
        }
    }
}
