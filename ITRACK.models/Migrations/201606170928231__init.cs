namespace ITRACK.models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MachineRequirements",
                c => new
                    {
                        MachineRequirementID = c.String(nullable: false, maxLength: 128),
                        StyleNo = c.String(),
                        LineNo = c.String(),
                        Remark = c.String(),
                        LocationCode = c.String(),
                        StyleID = c.String(maxLength: 128),
                        CreatedBy = c.String(),
                        CreatedTime = c.String(),
                        CreatedDate = c.DateTime(),
                        LastModifiedBy = c.String(),
                        LastModifiedAt = c.String(),
                    })
                .PrimaryKey(t => t.MachineRequirementID)
                .ForeignKey("dbo.Styles", t => t.StyleID)
                .Index(t => t.StyleID);
            
            CreateTable(
                "dbo.MachineRequirementItems",
                c => new
                    {
                        MachineRequirementItemID = c.Int(nullable: false, identity: true),
                        MachineType = c.String(),
                        Nos = c.Int(nullable: false),
                        Remark = c.String(),
                        MachineRequirementID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.MachineRequirementItemID)
                .ForeignKey("dbo.MachineRequirements", t => t.MachineRequirementID)
                .Index(t => t.MachineRequirementID);
            
            CreateTable(
                "dbo.StyleLoadings",
                c => new
                    {
                        StyleLoadingID = c.Int(nullable: false, identity: true),
                        LineNo = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        StyleID = c.String(maxLength: 128),
                        LocationCode = c.String(),
                    })
                .PrimaryKey(t => t.StyleLoadingID)
                .ForeignKey("dbo.Styles", t => t.StyleID)
                .Index(t => t.StyleID);
            
            CreateTable(
                "dbo.MachineTypes",
                c => new
                    {
                        MachineTypeID = c.String(nullable: false, maxLength: 128),
                        MachineTypeName = c.String(),
                        Remark = c.String(),
                        GroupID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.MachineTypeID)
                .ForeignKey("dbo.Groups", t => t.GroupID)
                .Index(t => t.GroupID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MachineTypes", "GroupID", "dbo.Groups");
            DropForeignKey("dbo.StyleLoadings", "StyleID", "dbo.Styles");
            DropForeignKey("dbo.MachineRequirements", "StyleID", "dbo.Styles");
            DropForeignKey("dbo.MachineRequirementItems", "MachineRequirementID", "dbo.MachineRequirements");
            DropIndex("dbo.MachineTypes", new[] { "GroupID" });
            DropIndex("dbo.StyleLoadings", new[] { "StyleID" });
            DropIndex("dbo.MachineRequirementItems", new[] { "MachineRequirementID" });
            DropIndex("dbo.MachineRequirements", new[] { "StyleID" });
            DropTable("dbo.MachineTypes");
            DropTable("dbo.StyleLoadings");
            DropTable("dbo.MachineRequirementItems");
            DropTable("dbo.MachineRequirements");
        }
    }
}
