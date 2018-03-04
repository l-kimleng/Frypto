namespace Frypto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPaymentModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PaymentDate = c.DateTime(nullable: false),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PaymentStatusId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PaymentStatus", t => t.PaymentStatusId, cascadeDelete: true)
                .Index(t => t.PaymentStatusId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Payments", "PaymentStatusId", "dbo.PaymentStatus");
            DropIndex("dbo.Payments", new[] { "PaymentStatusId" });
            DropTable("dbo.Payments");
        }
    }
}
