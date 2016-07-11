namespace ITRACK.models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _stId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OprationBarcodes", "StyleID", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.OprationBarcodes", "StyleID");
        }
    }
}
