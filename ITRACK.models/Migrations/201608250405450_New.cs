namespace ITRACK.models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class New : DbMigration
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
                        FabricType = c.String(),
                        StyleID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.CuttingRatioID)
                .ForeignKey("dbo.Styles", t => t.StyleID)
                .Index(t => t.StyleID);
            
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
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DepartmentID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Remark = c.String(),
                        CompanyID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DepartmentID)
                .ForeignKey("dbo.Companies", t => t.CompanyID)
                .Index(t => t.CompanyID);
            
            CreateTable(
                "dbo.FabricConsumptions",
                c => new
                    {
                        FabricConsumptionID = c.Int(nullable: false, identity: true),
                        StyleNo = c.String(),
                        PoNo = c.String(),
                        MarkerNo = c.String(),
                        Date = c.DateTime(nullable: false),
                        EstimateConsumtion = c.Double(nullable: false),
                        ActualConsumption = c.Double(nullable: false),
                        CompanyID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FabricConsumptionID)
                .ForeignKey("dbo.Companies", t => t.CompanyID)
                .Index(t => t.CompanyID);
            
            CreateTable(
                "dbo.FabricLedgers",
                c => new
                    {
                        FabricLedgerID = c.Int(nullable: false, identity: true),
                        MarkerNo = c.String(),
                        RollNo = c.String(),
                        NotedLength = c.Double(nullable: false),
                        Type = c.String(),
                        Date = c.DateTime(nullable: false),
                        MarkerLength = c.Double(nullable: false),
                        NoOfFlys = c.Int(nullable: false),
                        FabricUsed = c.Double(nullable: false),
                        NotedBalance = c.Double(nullable: false),
                        ActualBalance = c.Double(nullable: false),
                        StyleNo = c.String(),
                        StyleRef = c.String(),
                        CompanyID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FabricLedgerID)
                .ForeignKey("dbo.Companies", t => t.CompanyID)
                .Index(t => t.CompanyID);
            
            CreateTable(
                "dbo.EFAppointments",
                c => new
                    {
                        UniqueID = c.Int(nullable: false, identity: true),
                        Type = c.Int(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        AllDay = c.Boolean(nullable: false),
                        StyleID = c.String(),
                        StyleNo = c.String(),
                        Description = c.String(),
                        Status = c.Int(nullable: false),
                        Label = c.Int(nullable: false),
                        ResourceIDs = c.String(),
                        ReminderInfo = c.String(),
                        RecurrenceInfo = c.String(),
                    })
                .PrimaryKey(t => t.UniqueID);
            
            CreateTable(
                "dbo.EFResources",
                c => new
                    {
                        UniqueID = c.Int(nullable: false, identity: true),
                        ResourceID = c.Int(nullable: false),
                        ResourceName = c.String(),
                        Image = c.Binary(),
                        Color = c.Int(nullable: false),
                        ColorEx_A = c.Byte(nullable: false),
                        ColorEx_R = c.Byte(nullable: false),
                        ColorEx_G = c.Byte(nullable: false),
                        ColorEx_B = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.UniqueID);
            
            AddColumn("dbo.Styles", "StyleNo", c => c.String());
            AddColumn("dbo.CutIssuItems", "Length", c => c.String());
            AddColumn("dbo.CuttingItems", "LotNo", c => c.Int(nullable: false));
            AddColumn("dbo.PurchaseOrderHeaders", "PoNo", c => c.String());
            AddColumn("dbo.StyleLoadings", "AllDay", c => c.Boolean(nullable: false));
            AddColumn("dbo.StyleLoadings", "Subject", c => c.String());
            AddColumn("dbo.StyleLoadings", "Location", c => c.String());
            AddColumn("dbo.StyleLoadings", "Description", c => c.String());
            AddColumn("dbo.StyleLoadings", "Status", c => c.Int(nullable: false));
            AddColumn("dbo.StyleLoadings", "Label", c => c.Int(nullable: false));
            AddColumn("dbo.StyleLoadings", "ResourcesIDs", c => c.String());
            AddColumn("dbo.OprationBarcodes", "StyleID", c => c.String());
            AddColumn("dbo.SerialEntries", "RollWidth", c => c.Double(nullable: false));
            AddColumn("dbo.SerialEntries", "Shade", c => c.String());
            AddColumn("dbo.SerialEntries", "Shrinkage", c => c.Double(nullable: false));
            AddColumn("dbo.SpecialEntries", "StyleNo", c => c.String());
            AddColumn("dbo.SpecialEntries", "BOCNo", c => c.String());
            DropColumn("dbo.PurchaseOrderHeaders", "Article");
            DropColumn("dbo.PurchaseOrderHeaders", "Season");
            DropColumn("dbo.PurchaseOrderHeaders", "OrderPrice");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PurchaseOrderHeaders", "OrderPrice", c => c.Double(nullable: false));
            AddColumn("dbo.PurchaseOrderHeaders", "Season", c => c.String());
            AddColumn("dbo.PurchaseOrderHeaders", "Article", c => c.String());
            DropForeignKey("dbo.FabricLedgers", "CompanyID", "dbo.Companies");
            DropForeignKey("dbo.FabricConsumptions", "CompanyID", "dbo.Companies");
            DropForeignKey("dbo.Departments", "CompanyID", "dbo.Companies");
            DropForeignKey("dbo.CuttingRatios", "StyleID", "dbo.Styles");
            DropForeignKey("dbo.RatioItems", "CuttingRatioID", "dbo.CuttingRatios");
            DropForeignKey("dbo.EstimateFabricConsumptions", "StyleID", "dbo.Styles");
            DropForeignKey("dbo.EstimateFabricConsumptions", "CuttingRatioID", "dbo.CuttingRatios");
            DropIndex("dbo.FabricLedgers", new[] { "CompanyID" });
            DropIndex("dbo.FabricConsumptions", new[] { "CompanyID" });
            DropIndex("dbo.Departments", new[] { "CompanyID" });
            DropIndex("dbo.RatioItems", new[] { "CuttingRatioID" });
            DropIndex("dbo.EstimateFabricConsumptions", new[] { "CuttingRatioID" });
            DropIndex("dbo.EstimateFabricConsumptions", new[] { "StyleID" });
            DropIndex("dbo.CuttingRatios", new[] { "StyleID" });
            DropColumn("dbo.SpecialEntries", "BOCNo");
            DropColumn("dbo.SpecialEntries", "StyleNo");
            DropColumn("dbo.SerialEntries", "Shrinkage");
            DropColumn("dbo.SerialEntries", "Shade");
            DropColumn("dbo.SerialEntries", "RollWidth");
            DropColumn("dbo.OprationBarcodes", "StyleID");
            DropColumn("dbo.StyleLoadings", "ResourcesIDs");
            DropColumn("dbo.StyleLoadings", "Label");
            DropColumn("dbo.StyleLoadings", "Status");
            DropColumn("dbo.StyleLoadings", "Description");
            DropColumn("dbo.StyleLoadings", "Location");
            DropColumn("dbo.StyleLoadings", "Subject");
            DropColumn("dbo.StyleLoadings", "AllDay");
            DropColumn("dbo.PurchaseOrderHeaders", "PoNo");
            DropColumn("dbo.CuttingItems", "LotNo");
            DropColumn("dbo.CutIssuItems", "Length");
            DropColumn("dbo.Styles", "StyleNo");
            DropTable("dbo.EFResources");
            DropTable("dbo.EFAppointments");
            DropTable("dbo.FabricLedgers");
            DropTable("dbo.FabricConsumptions");
            DropTable("dbo.Departments");
            DropTable("dbo.RatioItems");
            DropTable("dbo.EstimateFabricConsumptions");
            DropTable("dbo.CuttingRatios");
        }
    }
}
