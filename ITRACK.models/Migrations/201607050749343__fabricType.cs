namespace ITRACK.models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _fabricType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CuttingRatios", "FabricType", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.CuttingRatios", "FabricType");
        }
    }
}
