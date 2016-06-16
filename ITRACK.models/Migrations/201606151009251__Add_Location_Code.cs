namespace ITRACK.models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _Add_Location_Code : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.StyleLoadings");
            AddColumn("dbo.MachineRequirements", "LocationCode", c => c.String());
            AddColumn("dbo.StyleLoadings", "LocationCode", c => c.String());
            AlterColumn("dbo.StyleLoadings", "StyleLoadingID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.StyleLoadings", "StyleLoadingID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.StyleLoadings");
            AlterColumn("dbo.StyleLoadings", "StyleLoadingID", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.StyleLoadings", "LocationCode");
            DropColumn("dbo.MachineRequirements", "LocationCode");
            AddPrimaryKey("dbo.StyleLoadings", "StyleLoadingID");
        }
    }
}
