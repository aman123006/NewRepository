namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ActiveFlag : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Customers");
            AddColumn("dbo.Customers", "Active", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Customers", "ID", c => c.Long(nullable: false, identity: true));
            AddPrimaryKey("dbo.Customers", "ID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Customers");
            AlterColumn("dbo.Customers", "ID", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.Customers", "Active");
            AddPrimaryKey("dbo.Customers", "ID");
        }
    }
}
