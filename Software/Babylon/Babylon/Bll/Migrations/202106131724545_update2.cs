namespace Bll.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Loan",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Started = c.Boolean(nullable: false),
                        DateFrom = c.DateTime(nullable: false),
                        DateTo = c.DateTime(nullable: false),
                        User_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.User", t => t.User_ID)
                .Index(t => t.User_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Loan", "User_ID", "dbo.User");
            DropIndex("dbo.Loan", new[] { "User_ID" });
            DropTable("dbo.Loan");
        }
    }
}
