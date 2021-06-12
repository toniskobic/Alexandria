namespace Bll.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Role",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RoleName = c.String(),
                        AuthorisationLevel = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.User", "Role_ID", "dbo.Role");
            DropIndex("dbo.User", new[] { "Role_ID" });
            DropTable("dbo.User");
            DropTable("dbo.Role");
        }
    }
}
