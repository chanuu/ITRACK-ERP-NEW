namespace ITRACK.models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class res_v5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StyleLoadings", "ResourcesIDs", c => c.String());
            AddColumn("dbo.Resources", "ResourcesID", c => c.Int(nullable: false));
            DropColumn("dbo.StyleLoadings", "ResurcesIDs");
            DropColumn("dbo.Resources", "ResurcesID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Resources", "ResurcesID", c => c.Int(nullable: false));
            AddColumn("dbo.StyleLoadings", "ResurcesIDs", c => c.String());
            DropColumn("dbo.Resources", "ResourcesID");
            DropColumn("dbo.StyleLoadings", "ResourcesIDs");
        }
    }
}
