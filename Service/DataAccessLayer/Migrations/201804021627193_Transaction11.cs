namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Transaction11 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Transactions", "Withdraw", c => c.Int());
            AddColumn("dbo.Transactions", "Deposit", c => c.Int());
            AddColumn("dbo.Transactions", "Balance", c => c.Long(nullable: false));
            DropColumn("dbo.Transactions", "Amount");
            DropColumn("dbo.Transactions", "PreviousBalnce");
            DropColumn("dbo.Transactions", "CurrentBalance");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Transactions", "CurrentBalance", c => c.Long(nullable: false));
            AddColumn("dbo.Transactions", "PreviousBalnce", c => c.Long(nullable: false));
            AddColumn("dbo.Transactions", "Amount", c => c.Int(nullable: false));
            DropColumn("dbo.Transactions", "Balance");
            DropColumn("dbo.Transactions", "Deposit");
            DropColumn("dbo.Transactions", "Withdraw");
        }
    }
}
