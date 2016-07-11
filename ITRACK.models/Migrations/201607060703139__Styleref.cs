namespace ITRACK.models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _Styleref : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FabricLedgers", "StyleRef", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.FabricLedgers", "StyleRef");
        }
    }
}
