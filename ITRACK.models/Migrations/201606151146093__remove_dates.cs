namespace ITRACK.models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _remove_dates : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.StyleLoadings", "StyleNo");
            DropColumn("dbo.StyleLoadings", "Remark");
            DropColumn("dbo.StyleLoadings", "CreatedBy");
            DropColumn("dbo.StyleLoadings", "CreatedTime");
            DropColumn("dbo.StyleLoadings", "CreatedDate");
            DropColumn("dbo.StyleLoadings", "LastModifiedBy");
            DropColumn("dbo.StyleLoadings", "LastModifiedAt");
        }
        
        public override void Down()
        {
            AddColumn("dbo.StyleLoadings", "LastModifiedAt", c => c.String());
            AddColumn("dbo.StyleLoadings", "LastModifiedBy", c => c.String());
            AddColumn("dbo.StyleLoadings", "CreatedDate", c => c.DateTime());
            AddColumn("dbo.StyleLoadings", "CreatedTime", c => c.String());
            AddColumn("dbo.StyleLoadings", "CreatedBy", c => c.String());
            AddColumn("dbo.StyleLoadings", "Remark", c => c.String());
            AddColumn("dbo.StyleLoadings", "StyleNo", c => c.String());
        }
    }
}
