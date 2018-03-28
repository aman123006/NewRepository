namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SSNID = c.Long(nullable: false),
                        Age = c.Int(nullable: false),
                        Name = c.String(),
                        AddressLine1 = c.String(),
                        AddressLine2 = c.String(),
                        City = c.String(),
                        State = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .Index(t => t.SSNID, unique: true);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Customers", new[] { "SSNID" });
            DropTable("dbo.Customers");
        }
    }
}
