namespace ITRACK.models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _cutiD : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CutIssuItems", "CutID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CutIssuItems", "CutID");
        }
    }
}
