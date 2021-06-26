namespace Bll.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update7 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Loan", "User_Id", "dbo.User");
            DropIndex("dbo.Loan", new[] { "User_Id" });
            RenameColumn(table: "dbo.Loan", name: "User_Id", newName: "UserId");
            RenameColumn(table: "dbo.User", name: "Role_Id", newName: "RoleId");
            RenameIndex(table: "dbo.User", name: "IX_Role_Id", newName: "IX_RoleId");
            AlterColumn("dbo.Loan", "UserId", c => c.Int(nullable: false));
            CreateIndex("dbo.Loan", "UserId");
            AddForeignKey("dbo.Loan", "UserId", "dbo.User", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Loan", "UserId", "dbo.User");
            DropIndex("dbo.Loan", new[] { "UserId" });
            AlterColumn("dbo.Loan", "UserId", c => c.Int());
            RenameIndex(table: "dbo.User", name: "IX_RoleId", newName: "IX_Role_Id");
            RenameColumn(table: "dbo.User", name: "RoleId", newName: "Role_Id");
            RenameColumn(table: "dbo.Loan", name: "UserId", newName: "User_Id");
            CreateIndex("dbo.Loan", "User_Id");
            AddForeignKey("dbo.Loan", "User_Id", "dbo.User", "Id");
        }
    }
}
