namespace Bll.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update3 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Literature", new[] { "Author_ID" });
            DropIndex("dbo.Literature", new[] { "Category_ID" });
            DropIndex("dbo.Loan", new[] { "User_ID" });
            DropIndex("dbo.User", new[] { "Role_ID" });
            DropIndex("dbo.Receipt", new[] { "User_ID" });
            DropIndex("dbo.Receipt", new[] { "Employee_ID" });
            DropIndex("dbo.Membership", new[] { "User_ID" });
            CreateTable(
                "dbo.PickingIn",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PickingOut",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Literature", "Author_Id");
            CreateIndex("dbo.Literature", "Category_Id");
            CreateIndex("dbo.Loan", "User_Id");
            CreateIndex("dbo.User", "Role_Id");
            CreateIndex("dbo.Receipt", "User_Id");
            CreateIndex("dbo.Receipt", "Employee_Id");
            CreateIndex("dbo.Membership", "User_Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Membership", new[] { "User_Id" });
            DropIndex("dbo.Receipt", new[] { "Employee_Id" });
            DropIndex("dbo.Receipt", new[] { "User_Id" });
            DropIndex("dbo.User", new[] { "Role_Id" });
            DropIndex("dbo.Loan", new[] { "User_Id" });
            DropIndex("dbo.Literature", new[] { "Category_Id" });
            DropIndex("dbo.Literature", new[] { "Author_Id" });
            DropTable("dbo.PickingOut");
            DropTable("dbo.PickingIn");
            CreateIndex("dbo.Membership", "User_ID");
            CreateIndex("dbo.Receipt", "Employee_ID");
            CreateIndex("dbo.Receipt", "User_ID");
            CreateIndex("dbo.User", "Role_ID");
            CreateIndex("dbo.Loan", "User_ID");
            CreateIndex("dbo.Literature", "Category_ID");
            CreateIndex("dbo.Literature", "Author_ID");
        }
    }
}
