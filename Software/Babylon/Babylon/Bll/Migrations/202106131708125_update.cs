namespace Bll.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Membership",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DateFrom = c.DateTime(nullable: false),
                        DateTo = c.DateTime(nullable: false),
                        User_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.User", t => t.User_ID)
                .Index(t => t.User_ID);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        EMail = c.String(),
                        Password = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        RegistrationDate = c.DateTime(nullable: false),
                        ExpirationDate = c.DateTime(nullable: false),
                        PhoneNumber = c.String(),
                        Locked = c.Boolean(nullable: false),
                        Role_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Role", t => t.Role_ID)
                .Index(t => t.Role_ID);
            
            CreateTable(
                "dbo.Receipt",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DateOfIssue = c.DateTime(nullable: false),
                        User_ID = c.Int(nullable: false),
                        Employee_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.User", t => t.Employee_ID)
                .ForeignKey("dbo.User", t => t.User_ID)
                .Index(t => t.User_ID)
                .Index(t => t.Employee_ID);
            
            CreateTable(
                "dbo.Role",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RoleName = c.String(),
                        AuthorisationLevel = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.User", "Role_ID", "dbo.Role");
            DropForeignKey("dbo.Membership", "User_ID", "dbo.User");
            DropForeignKey("dbo.Receipt", "User_ID", "dbo.User");
            DropForeignKey("dbo.Receipt", "Employee_ID", "dbo.User");
            DropIndex("dbo.Receipt", new[] { "Employee_ID" });
            DropIndex("dbo.Receipt", new[] { "User_ID" });
            DropIndex("dbo.User", new[] { "Role_ID" });
            DropIndex("dbo.Membership", new[] { "User_ID" });
            DropTable("dbo.Role");
            DropTable("dbo.Receipt");
            DropTable("dbo.User");
            DropTable("dbo.Membership");
        }
    }
}
