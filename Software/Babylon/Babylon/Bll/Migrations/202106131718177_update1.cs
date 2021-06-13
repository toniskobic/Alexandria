namespace Bll.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Author",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Literature",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Author_ID = c.Int(),
                        Category_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Author", t => t.Author_ID)
                .ForeignKey("dbo.Category", t => t.Category_ID)
                .Index(t => t.Author_ID)
                .Index(t => t.Category_ID);
            
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Literature", "Category_ID", "dbo.Category");
            DropForeignKey("dbo.Literature", "Author_ID", "dbo.Author");
            DropIndex("dbo.Literature", new[] { "Category_ID" });
            DropIndex("dbo.Literature", new[] { "Author_ID" });
            DropTable("dbo.Category");
            DropTable("dbo.Literature");
            DropTable("dbo.Author");
        }
    }
}
