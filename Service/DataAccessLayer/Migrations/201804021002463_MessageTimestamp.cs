namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MessageTimestamp : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Message", c => c.String());
            AddColumn("dbo.Customers", "LastUpdated", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "LastUpdated");
            DropColumn("dbo.Customers", "Message");
        }
    }
}
