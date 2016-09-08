namespace ITRACK.models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _cutiD : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RentManagements",
                c => new
                    {
                        RentManagementID = c.String(nullable: false, maxLength: 128),
                        MachineType = c.String(),
                        MachineSerialNo = c.String(),
                        AssetBarcode = c.String(),
                        FromDate = c.DateTime(nullable: false),
                        ToDate = c.DateTime(nullable: false),
                        Remark = c.String(),
                    })
                .PrimaryKey(t => t.RentManagementID);
            
            AddColumn("dbo.CutIssuItems", "CutID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CutIssuItems", "CutID");
            DropTable("dbo.RentManagements");
        }
    }
}
