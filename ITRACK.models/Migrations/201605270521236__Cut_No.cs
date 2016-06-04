namespace ITRACK.models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _Cut_No : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CuttingItems", "CutNo", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CuttingItems", "CutNo", c => c.Int(nullable: false));
        }
    }
}
