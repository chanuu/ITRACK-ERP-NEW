namespace ITRACK.models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V8 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EFAppointments", "StyleID", c => c.String());
            AddColumn("dbo.EFAppointments", "StyleNo", c => c.String());
            DropColumn("dbo.EFAppointments", "Subject");
            DropColumn("dbo.EFAppointments", "LineNo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.EFAppointments", "LineNo", c => c.String());
            AddColumn("dbo.EFAppointments", "Subject", c => c.String());
            DropColumn("dbo.EFAppointments", "StyleNo");
            DropColumn("dbo.EFAppointments", "StyleID");
        }
    }
}
