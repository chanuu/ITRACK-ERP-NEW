namespace ITRACK.models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _fabric_Consumption : DbMigration
    {
        public override void Up()
        {
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
                        RoallNo = c.String(),
                        NotedLength = c.String(),
                        Type = c.String(),
                        Date = c.DateTime(nullable: false),
                        MarkerLength = c.Double(nullable: false),
                        NoOfFlys = c.Int(nullable: false),
                        FabricUsed = c.Double(nullable: false),
                        NotedBalance = c.Double(nullable: false),
                        ActualBalance = c.Double(nullable: false),
                        CompanyID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FabricLedgerID)
                .ForeignKey("dbo.Companies", t => t.CompanyID)
                .Index(t => t.CompanyID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FabricLedgers", "CompanyID", "dbo.Companies");
            DropForeignKey("dbo.FabricConsumptions", "CompanyID", "dbo.Companies");
            DropIndex("dbo.FabricLedgers", new[] { "CompanyID" });
            DropIndex("dbo.FabricConsumptions", new[] { "CompanyID" });
            DropTable("dbo.FabricLedgers");
            DropTable("dbo.FabricConsumptions");
        }
    }
}
