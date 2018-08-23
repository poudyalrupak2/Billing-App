namespace DemoApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Admin1", "CreatedBy", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Admin1", "CreatedBy");
        }
    }
}
