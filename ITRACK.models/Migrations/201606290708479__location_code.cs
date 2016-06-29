namespace ITRACK.models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _location_code : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Styles", "StyleNo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Styles", "StyleNo");
        }
    }
}
