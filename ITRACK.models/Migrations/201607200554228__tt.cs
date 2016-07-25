namespace ITRACK.models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _tt : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EstimateFabricConsumptions",
                c => new
                    {
                        EstimateFabricConsumptionID = c.String(nullable: false, maxLength: 128),
                        StyleID = c.String(maxLength: 128),
                        MarkerNo = c.String(),
                        Date = c.DateTime(nullable: false),
                        NoofPlys = c.Int(nullable: false),
                        SinglePcsConsumtion = c.Double(nullable: false),
                        TotalFabricUsed = c.Double(nullable: false),
                        TotalPcs = c.Int(nullable: false),
                        ActualFabUsed = c.Double(nullable: false),
                        Defference = c.Double(nullable: false),
                        CuttingRatioID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.EstimateFabricConsumptionID)
                .ForeignKey("dbo.CuttingRatios", t => t.CuttingRatioID)
                .ForeignKey("dbo.Styles", t => t.StyleID)
                .Index(t => t.StyleID)
                .Index(t => t.CuttingRatioID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EstimateFabricConsumptions", "StyleID", "dbo.Styles");
            DropForeignKey("dbo.EstimateFabricConsumptions", "CuttingRatioID", "dbo.CuttingRatios");
            DropIndex("dbo.EstimateFabricConsumptions", new[] { "CuttingRatioID" });
            DropIndex("dbo.EstimateFabricConsumptions", new[] { "StyleID" });
            DropTable("dbo.EstimateFabricConsumptions");
        }
    }
}
