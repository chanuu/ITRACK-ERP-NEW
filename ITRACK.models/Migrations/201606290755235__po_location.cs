namespace ITRACK.models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _po_location : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PurchaseOrderHeaders", "PoNo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.PurchaseOrderHeaders", "PoNo");
        }
    }
}
