namespace ITRACK.models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class res_v2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Resources", "LineNo", c => c.String());
            DropColumn("dbo.Resources", "ResourceName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Resources", "ResourceName", c => c.String());
            DropColumn("dbo.Resources", "LineNo");
        }
    }
}
