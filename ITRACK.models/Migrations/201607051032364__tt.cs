namespace ITRACK.models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _tt : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FabricLedgers", "RollNo", c => c.String());
            AlterColumn("dbo.FabricLedgers", "NotedLength", c => c.Double(nullable: false));
            DropColumn("dbo.FabricLedgers", "RoallNo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.FabricLedgers", "RoallNo", c => c.String());
            AlterColumn("dbo.FabricLedgers", "NotedLength", c => c.String());
            DropColumn("dbo.FabricLedgers", "RollNo");
        }
    }
}
