namespace ITRACK.models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _add_lot : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CuttingRatios",
                c => new
                    {
                        CuttingRatioID = c.String(nullable: false, maxLength: 128),
                        Color = c.String(),
                        Length = c.String(),
                        MarkerLength = c.Double(nullable: false),
                        MarkerWidth = c.Double(nullable: false),
                        Remark = c.String(),
                        StyleID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.CuttingRatioID)
                .ForeignKey("dbo.Styles", t => t.StyleID)
                .Index(t => t.StyleID);
            
            CreateTable(
                "dbo.RatioItems",
                c => new
                    {
                        RatioItemID = c.Int(nullable: false, identity: true),
                        Size = c.String(),
                        Lot = c.Int(nullable: false),
                        CuttingRatioID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.RatioItemID)
                .ForeignKey("dbo.CuttingRatios", t => t.CuttingRatioID)
                .Index(t => t.CuttingRatioID);
            
            AddColumn("dbo.CutIssuItems", "Length", c => c.String());
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CuttingRatios", "StyleID", "dbo.Styles");
            DropForeignKey("dbo.RatioItems", "CuttingRatioID", "dbo.CuttingRatios");
            DropIndex("dbo.RatioItems", new[] { "CuttingRatioID" });
            DropIndex("dbo.CuttingRatios", new[] { "StyleID" });
            DropColumn("dbo.CutIssuItems", "Length");
            DropTable("dbo.RatioItems");
            DropTable("dbo.CuttingRatios");
        }
    }
}
