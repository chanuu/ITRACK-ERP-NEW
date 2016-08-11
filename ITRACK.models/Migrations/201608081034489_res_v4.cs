namespace ITRACK.models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class res_v4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StyleLoadings", "ResurcesIDs", c => c.String());
            AddColumn("dbo.Resources", "ResurcesID", c => c.Int(nullable: false));
            DropColumn("dbo.Resources", "dtoResurcesID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Resources", "dtoResurcesID", c => c.Int(nullable: false));
            DropColumn("dbo.Resources", "ResurcesID");
            DropColumn("dbo.StyleLoadings", "ResurcesIDs");
        }
    }
}
