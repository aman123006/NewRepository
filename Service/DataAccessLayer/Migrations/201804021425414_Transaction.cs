namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Transaction : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        AccountID = c.Long(nullable: false),
                        TransactionType = c.String(),
                        Amount = c.Int(nullable: false),
                        PreviousBalnce = c.Long(nullable: false),
                        CurrentBalance = c.Long(nullable: false),
                        Comments = c.String(),
                        TransactionDTTM = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Transactions");
        }
    }
}
