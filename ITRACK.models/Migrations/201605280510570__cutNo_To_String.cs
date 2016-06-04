namespace ITRACK.models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _cutNo_To_String : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.BundleDetails", "CutNo", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.BundleDetails", "CutNo", c => c.Long(nullable: false));
        }
    }
}
