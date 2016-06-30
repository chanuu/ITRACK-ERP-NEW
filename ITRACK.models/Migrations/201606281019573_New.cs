namespace ITRACK.models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class New : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AssetRequisitionDetails",
                c => new
                    {
                        AssetRequisitionDetailsID = c.Int(nullable: false, identity: true),
                        AssetNo = c.String(),
                        FromDate = c.DateTime(nullable: false),
                        ToDate = c.DateTime(nullable: false),
                        AssetRequisitionID = c.String(maxLength: 128),
                        AssetBarcode_AssetBarcodeID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.AssetRequisitionDetailsID)
                .ForeignKey("dbo.AssetBarcodes", t => t.AssetBarcode_AssetBarcodeID)
                .ForeignKey("dbo.AssetRequisitions", t => t.AssetRequisitionID)
                .Index(t => t.AssetRequisitionID)
                .Index(t => t.AssetBarcode_AssetBarcodeID);
            
            CreateTable(
                "dbo.AssetRequisitions",
                c => new
                    {
                        AssetRequisitionID = c.String(nullable: false, maxLength: 128),
                        LocationCode = c.String(),
                        CompanyCode = c.String(),
                        DocumentType = c.String(),
                        DocumentDate = c.DateTime(nullable: false),
                        TargetLocationCode = c.String(),
                        AssetRequisitionDetailsID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AssetRequisitionID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AssetRequisitionDetails", "AssetRequisitionID", "dbo.AssetRequisitions");
            DropForeignKey("dbo.AssetRequisitionDetails", "AssetBarcode_AssetBarcodeID", "dbo.AssetBarcodes");
            DropIndex("dbo.AssetRequisitionDetails", new[] { "AssetBarcode_AssetBarcodeID" });
            DropIndex("dbo.AssetRequisitionDetails", new[] { "AssetRequisitionID" });
            DropTable("dbo.AssetRequisitions");
            DropTable("dbo.AssetRequisitionDetails");
        }
    }
}
