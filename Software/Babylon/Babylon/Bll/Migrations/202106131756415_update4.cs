namespace Bll.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LoanItem",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Literature_Id = c.Int(),
                        Loan_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Literature", t => t.Literature_Id)
                .ForeignKey("dbo.Loan", t => t.Loan_Id)
                .Index(t => t.Literature_Id)
                .Index(t => t.Loan_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LoanItem", "Loan_Id", "dbo.Loan");
            DropForeignKey("dbo.LoanItem", "Literature_Id", "dbo.Literature");
            DropIndex("dbo.LoanItem", new[] { "Loan_Id" });
            DropIndex("dbo.LoanItem", new[] { "Literature_Id" });
            DropTable("dbo.LoanItem");
        }
    }
}
