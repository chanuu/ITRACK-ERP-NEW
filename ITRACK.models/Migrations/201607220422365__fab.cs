namespace ITRACK.models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _fab : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SerialEntries", "RollWidth", c => c.Double(nullable: false));
            AddColumn("dbo.SerialEntries", "Shade", c => c.String());
            AddColumn("dbo.SerialEntries", "Shrinkage", c => c.Double(nullable: false));
            AddColumn("dbo.SpecialEntries", "StyleNo", c => c.String());
            AddColumn("dbo.SpecialEntries", "BOCNo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.SpecialEntries", "BOCNo");
            DropColumn("dbo.SpecialEntries", "StyleNo");
            DropColumn("dbo.SerialEntries", "Shrinkage");
            DropColumn("dbo.SerialEntries", "Shade");
            DropColumn("dbo.SerialEntries", "RollWidth");
        }
    }
}
