namespace ITRACK.models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _v78 : DbMigration
    {
        public override void Up()
        {
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
        }
        
        public override void Down()
        {
            DropColumn("dbo.StyleLoadings", "ResourcesIDs");
            DropColumn("dbo.StyleLoadings", "Label");
            DropColumn("dbo.StyleLoadings", "Status");
            DropColumn("dbo.StyleLoadings", "Description");
            DropColumn("dbo.StyleLoadings", "Location");
            DropColumn("dbo.StyleLoadings", "Subject");
            DropColumn("dbo.StyleLoadings", "AllDay");
            DropTable("dbo.EFResources");
            DropTable("dbo.EFAppointments");
        }
    }
}
