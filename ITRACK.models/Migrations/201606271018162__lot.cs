namespace ITRACK.models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _lot : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CuttingItems", "LotNo", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CuttingItems", "LotNo");
        }
    }
}
