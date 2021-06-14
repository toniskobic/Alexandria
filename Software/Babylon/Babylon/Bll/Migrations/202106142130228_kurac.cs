namespace Bll.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class kurac : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.LoanItem", "Literature_Id", "dbo.Literature");
            DropForeignKey("dbo.LoanItem", "Loan_Id", "dbo.Loan");
            DropIndex("dbo.LoanItem", new[] { "Literature_Id" });
            DropIndex("dbo.LoanItem", new[] { "Loan_Id" });
            RenameColumn(table: "dbo.LoanItem", name: "Literature_Id", newName: "LiteratureId");
            RenameColumn(table: "dbo.LoanItem", name: "Loan_Id", newName: "LoanId");
            AlterColumn("dbo.LoanItem", "LiteratureId", c => c.Int(nullable: false));
            AlterColumn("dbo.LoanItem", "LoanId", c => c.Int(nullable: false));
            CreateIndex("dbo.LoanItem", "LoanId");
            CreateIndex("dbo.LoanItem", "LiteratureId");
            AddForeignKey("dbo.LoanItem", "LiteratureId", "dbo.Literature", "Id", cascadeDelete: true);
            AddForeignKey("dbo.LoanItem", "LoanId", "dbo.Loan", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LoanItem", "LoanId", "dbo.Loan");
            DropForeignKey("dbo.LoanItem", "LiteratureId", "dbo.Literature");
            DropIndex("dbo.LoanItem", new[] { "LiteratureId" });
            DropIndex("dbo.LoanItem", new[] { "LoanId" });
            AlterColumn("dbo.LoanItem", "LoanId", c => c.Int());
            AlterColumn("dbo.LoanItem", "LiteratureId", c => c.Int());
            RenameColumn(table: "dbo.LoanItem", name: "LoanId", newName: "Loan_Id");
            RenameColumn(table: "dbo.LoanItem", name: "LiteratureId", newName: "Literature_Id");
            CreateIndex("dbo.LoanItem", "Loan_Id");
            CreateIndex("dbo.LoanItem", "Literature_Id");
            AddForeignKey("dbo.LoanItem", "Loan_Id", "dbo.Loan", "Id");
            AddForeignKey("dbo.LoanItem", "Literature_Id", "dbo.Literature", "Id");
        }
    }
}
