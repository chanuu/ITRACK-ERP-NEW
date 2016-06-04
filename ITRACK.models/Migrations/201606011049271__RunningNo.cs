namespace ITRACK.models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _RunningNo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RunningNoes",
                c => new
                    {
                        RunningNoID = c.String(nullable: false, maxLength: 128),
                        Code = c.String(),
                        Starting = c.Int(nullable: false),
                        Length = c.Int(nullable: false),
                        Prefix = c.String(),
                        Venue = c.String(),
                        CompanyID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RunningNoID)
                .ForeignKey("dbo.Companies", t => t.CompanyID)
                .Index(t => t.CompanyID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RunningNoes", "CompanyID", "dbo.Companies");
            DropIndex("dbo.RunningNoes", new[] { "CompanyID" });
            DropTable("dbo.RunningNoes");
        }
    }
}
