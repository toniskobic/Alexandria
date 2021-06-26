namespace Bll.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update6 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.User", "Role_Id", "dbo.Role");
            DropIndex("dbo.User", new[] { "Role_Id" });
            AlterColumn("dbo.User", "Role_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.User", "Role_Id");
            AddForeignKey("dbo.User", "Role_Id", "dbo.Role", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.User", "Role_Id", "dbo.Role");
            DropIndex("dbo.User", new[] { "Role_Id" });
            AlterColumn("dbo.User", "Role_Id", c => c.Int());
            CreateIndex("dbo.User", "Role_Id");
            AddForeignKey("dbo.User", "Role_Id", "dbo.Role", "Id");
        }
    }
}
