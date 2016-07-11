namespace ITRACK.models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _st : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FabricLedgers", "StyleNo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.FabricLedgers", "StyleNo");
        }
    }
}
