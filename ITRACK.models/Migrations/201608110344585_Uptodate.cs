namespace ITRACK.models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Uptodate : DbMigration
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
            
            AddColumn("dbo.StyleLoadings", "AllDay", c => c.Boolean(nullable: false));
            AddColumn("dbo.StyleLoadings", "Subject", c => c.String());
            AddColumn("dbo.StyleLoadings", "Location", c => c.String());
            AddColumn("dbo.StyleLoadings", "Description", c => c.String());
            AddColumn("dbo.StyleLoadings", "Status", c => c.Int(nullable: false));
            AddColumn("dbo.StyleLoadings", "Label", c => c.Int(nullable: false));
            AddColumn("dbo.StyleLoadings", "ResourcesIDs", c => c.String());
            AddColumn("dbo.SerialEntries", "RollWidth", c => c.Double(nullable: false));
            AddColumn("dbo.SerialEntries", "Shade", c => c.String());
            AddColumn("dbo.SerialEntries", "Shrinkage", c => c.Double(nullable: false));
            AddColumn("dbo.SpecialEntries", "StyleNo", c => c.String());
            AddColumn("dbo.SpecialEntries", "BOCNo", c => c.String());
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EstimateFabricConsumptions", "StyleID", "dbo.Styles");
            DropForeignKey("dbo.EstimateFabricConsumptions", "CuttingRatioID", "dbo.CuttingRatios");
            DropIndex("dbo.EstimateFabricConsumptions", new[] { "CuttingRatioID" });
            DropIndex("dbo.EstimateFabricConsumptions", new[] { "StyleID" });
            DropColumn("dbo.SpecialEntries", "BOCNo");
            DropColumn("dbo.SpecialEntries", "StyleNo");
            DropColumn("dbo.SerialEntries", "Shrinkage");
            DropColumn("dbo.SerialEntries", "Shade");
            DropColumn("dbo.SerialEntries", "RollWidth");
            DropColumn("dbo.StyleLoadings", "ResourcesIDs");
            DropColumn("dbo.StyleLoadings", "Label");
            DropColumn("dbo.StyleLoadings", "Status");
            DropColumn("dbo.StyleLoadings", "Description");
            DropColumn("dbo.StyleLoadings", "Location");
            DropColumn("dbo.StyleLoadings", "Subject");
            DropColumn("dbo.StyleLoadings", "AllDay");
            DropTable("dbo.EFResources");
            DropTable("dbo.EFAppointments");
            DropTable("dbo.EstimateFabricConsumptions");
        }
    }
}
