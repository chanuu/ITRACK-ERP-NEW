namespace ITRACK.models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _remove_order_price : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.PurchaseOrderHeaders", "Article");
            DropColumn("dbo.PurchaseOrderHeaders", "Season");
            DropColumn("dbo.PurchaseOrderHeaders", "OrderPrice");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PurchaseOrderHeaders", "OrderPrice", c => c.Double(nullable: false));
            AddColumn("dbo.PurchaseOrderHeaders", "Season", c => c.String());
            AddColumn("dbo.PurchaseOrderHeaders", "Article", c => c.String());
        }
    }
}
