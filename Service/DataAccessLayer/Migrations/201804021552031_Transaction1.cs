namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Transaction1 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Transactions", "AccountID");
            AddForeignKey("dbo.Transactions", "AccountID", "dbo.Accounts", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transactions", "AccountID", "dbo.Accounts");
            DropIndex("dbo.Transactions", new[] { "AccountID" });
        }
    }
}
