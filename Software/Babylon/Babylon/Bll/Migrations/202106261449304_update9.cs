namespace Bll.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update9 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Loan", "UserId", "dbo.User");
            DropForeignKey("dbo.User", "RoleId", "dbo.Role");
            DropIndex("dbo.Loan", new[] { "UserId" });
            DropIndex("dbo.User", new[] { "RoleId" });
            RenameColumn(table: "dbo.Loan", name: "UserId", newName: "User_Id");
            RenameColumn(table: "dbo.User", name: "RoleId", newName: "Role_Id");
            AlterColumn("dbo.Loan", "User_Id", c => c.Int());
            AlterColumn("dbo.User", "Role_Id", c => c.Int());
            CreateIndex("dbo.Loan", "User_Id");
            CreateIndex("dbo.User", "Role_Id");
            AddForeignKey("dbo.Loan", "User_Id", "dbo.User", "Id");
            AddForeignKey("dbo.User", "Role_Id", "dbo.Role", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.User", "Role_Id", "dbo.Role");
            DropForeignKey("dbo.Loan", "User_Id", "dbo.User");
            DropIndex("dbo.User", new[] { "Role_Id" });
            DropIndex("dbo.Loan", new[] { "User_Id" });
            AlterColumn("dbo.User", "Role_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Loan", "User_Id", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.User", name: "Role_Id", newName: "RoleId");
            RenameColumn(table: "dbo.Loan", name: "User_Id", newName: "UserId");
            CreateIndex("dbo.User", "RoleId");
            CreateIndex("dbo.Loan", "UserId");
            AddForeignKey("dbo.User", "RoleId", "dbo.Role", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Loan", "UserId", "dbo.User", "Id", cascadeDelete: true);
        }
    }
}
