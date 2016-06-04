namespace ITRACK.models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _01 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.CuttingLedgers");
            AddPrimaryKey("dbo.CuttingLedgers", new[] { "Date", "StyleNo", "Po", "LineNo", "Size", "Color", "TrasctionType" });
            DropColumn("dbo.CuttingLedgers", "DocNo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CuttingLedgers", "DocNo", c => c.String(nullable: false, maxLength: 128));
            DropPrimaryKey("dbo.CuttingLedgers");
            AddPrimaryKey("dbo.CuttingLedgers", new[] { "Date", "StyleNo", "Po", "LineNo", "Size", "Color", "TrasctionType", "DocNo" });
        }
    }
}
