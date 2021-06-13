namespace Bll.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Author",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Literature",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Author_Id = c.Int(),
                        Category_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Author", t => t.Author_Id)
                .ForeignKey("dbo.Category", t => t.Category_Id)
                .Index(t => t.Author_Id)
                .Index(t => t.Category_Id);
            
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
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
            
            CreateTable(
                "dbo.Loan",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Started = c.Boolean(nullable: false),
                        DateFrom = c.DateTime(nullable: false),
                        DateTo = c.DateTime(nullable: false),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        EMail = c.String(),
                        Password = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        RegistrationDate = c.DateTime(nullable: false),
                        ExpirationDate = c.DateTime(nullable: false),
                        PhoneNumber = c.String(),
                        Locked = c.Boolean(nullable: false),
                        Role_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Role", t => t.Role_Id)
                .Index(t => t.Role_Id);
            
            CreateTable(
                "dbo.Receipt",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateOfIssue = c.DateTime(nullable: false),
                        User_Id = c.Int(nullable: false),
                        Employee_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.Employee_Id)
                .ForeignKey("dbo.User", t => t.User_Id)
                .Index(t => t.User_Id)
                .Index(t => t.Employee_Id);
            
            CreateTable(
                "dbo.Membership",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateFrom = c.DateTime(nullable: false),
                        DateTo = c.DateTime(nullable: false),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Role",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoleName = c.String(),
                        AuthorisationLevel = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PickingInItem",
                c => new
                    {
                        PickingIn_Id = c.Int(nullable: false),
                        Literaure_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.PickingIn_Id, t.Literaure_Id })
                .ForeignKey("dbo.Literature", t => t.Literaure_Id, cascadeDelete: true)
                .ForeignKey("dbo.PickingIn", t => t.PickingIn_Id, cascadeDelete: true)
                .Index(t => t.PickingIn_Id)
                .Index(t => t.Literaure_Id);
            
            CreateTable(
                "dbo.PickingIn",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PickingOutItem",
                c => new
                    {
                        PickingOut_Id = c.Int(nullable: false),
                        Literaure_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.PickingOut_Id, t.Literaure_Id })
                .ForeignKey("dbo.Literature", t => t.Literaure_Id, cascadeDelete: true)
                .ForeignKey("dbo.PickingOut", t => t.PickingOut_Id, cascadeDelete: true)
                .Index(t => t.PickingOut_Id)
                .Index(t => t.Literaure_Id);
            
            CreateTable(
                "dbo.PickingOut",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PickingOutItem", "PickingOut_Id", "dbo.PickingOut");
            DropForeignKey("dbo.PickingOutItem", "Literaure_Id", "dbo.Literature");
            DropForeignKey("dbo.PickingInItem", "PickingIn_Id", "dbo.PickingIn");
            DropForeignKey("dbo.PickingInItem", "Literaure_Id", "dbo.Literature");
            DropForeignKey("dbo.User", "Role_Id", "dbo.Role");
            DropForeignKey("dbo.Membership", "User_Id", "dbo.User");
            DropForeignKey("dbo.Loan", "User_Id", "dbo.User");
            DropForeignKey("dbo.Receipt", "User_Id", "dbo.User");
            DropForeignKey("dbo.Receipt", "Employee_Id", "dbo.User");
            DropForeignKey("dbo.LoanItem", "Loan_Id", "dbo.Loan");
            DropForeignKey("dbo.LoanItem", "Literature_Id", "dbo.Literature");
            DropForeignKey("dbo.Literature", "Category_Id", "dbo.Category");
            DropForeignKey("dbo.Literature", "Author_Id", "dbo.Author");
            DropIndex("dbo.PickingOutItem", new[] { "Literaure_Id" });
            DropIndex("dbo.PickingOutItem", new[] { "PickingOut_Id" });
            DropIndex("dbo.PickingInItem", new[] { "Literaure_Id" });
            DropIndex("dbo.PickingInItem", new[] { "PickingIn_Id" });
            DropIndex("dbo.Membership", new[] { "User_Id" });
            DropIndex("dbo.Receipt", new[] { "Employee_Id" });
            DropIndex("dbo.Receipt", new[] { "User_Id" });
            DropIndex("dbo.User", new[] { "Role_Id" });
            DropIndex("dbo.Loan", new[] { "User_Id" });
            DropIndex("dbo.LoanItem", new[] { "Loan_Id" });
            DropIndex("dbo.LoanItem", new[] { "Literature_Id" });
            DropIndex("dbo.Literature", new[] { "Category_Id" });
            DropIndex("dbo.Literature", new[] { "Author_Id" });
            DropTable("dbo.PickingOut");
            DropTable("dbo.PickingOutItem");
            DropTable("dbo.PickingIn");
            DropTable("dbo.PickingInItem");
            DropTable("dbo.Role");
            DropTable("dbo.Membership");
            DropTable("dbo.Receipt");
            DropTable("dbo.User");
            DropTable("dbo.Loan");
            DropTable("dbo.LoanItem");
            DropTable("dbo.Category");
            DropTable("dbo.Literature");
            DropTable("dbo.Author");
        }
    }
}
