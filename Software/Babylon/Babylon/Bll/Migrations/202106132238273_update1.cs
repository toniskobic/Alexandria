namespace Bll.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update1 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.PickingInItem", name: "Literaure_Id", newName: "Literature_Id");
            RenameColumn(table: "dbo.PickingOutItem", name: "Literaure_Id", newName: "Literature_Id");
            RenameIndex(table: "dbo.PickingInItem", name: "IX_Literaure_Id", newName: "IX_Literature_Id");
            RenameIndex(table: "dbo.PickingOutItem", name: "IX_Literaure_Id", newName: "IX_Literature_Id");
            CreateTable(
                "dbo.ReceiptItem",
                c => new
                    {
                        Receipt_Id = c.Int(nullable: false),
                        Loan_Id = c.Int(nullable: false),
                        Money = c.Double(nullable: false),
                    })
                .PrimaryKey(t => new { t.Receipt_Id, t.Loan_Id })
                .ForeignKey("dbo.Loan", t => t.Loan_Id, cascadeDelete: true)
                .ForeignKey("dbo.Receipt", t => t.Receipt_Id, cascadeDelete: true)
                .Index(t => t.Receipt_Id)
                .Index(t => t.Loan_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ReceiptItem", "Receipt_Id", "dbo.Receipt");
            DropForeignKey("dbo.ReceiptItem", "Loan_Id", "dbo.Loan");
            DropIndex("dbo.ReceiptItem", new[] { "Loan_Id" });
            DropIndex("dbo.ReceiptItem", new[] { "Receipt_Id" });
            DropTable("dbo.ReceiptItem");
            RenameIndex(table: "dbo.PickingOutItem", name: "IX_Literature_Id", newName: "IX_Literaure_Id");
            RenameIndex(table: "dbo.PickingInItem", name: "IX_Literature_Id", newName: "IX_Literaure_Id");
            RenameColumn(table: "dbo.PickingOutItem", name: "Literature_Id", newName: "Literaure_Id");
            RenameColumn(table: "dbo.PickingInItem", name: "Literature_Id", newName: "Literaure_Id");
        }
    }
}
