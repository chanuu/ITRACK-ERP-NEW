namespace ITRACK.models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _departments : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DepartmentID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Remark = c.String(),
                        CompanyID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DepartmentID)
                .ForeignKey("dbo.Companies", t => t.CompanyID)
                .Index(t => t.CompanyID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Departments", "CompanyID", "dbo.Companies");
            DropIndex("dbo.Departments", new[] { "CompanyID" });
            DropTable("dbo.Departments");
        }
    }
}
