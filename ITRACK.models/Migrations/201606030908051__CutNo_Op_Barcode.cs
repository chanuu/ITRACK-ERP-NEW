namespace ITRACK.models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _CutNo_Op_Barcode : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OprationBarcodes", "CutNo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.OprationBarcodes", "CutNo");
        }
    }
}
