namespace Bll.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update5 : DbMigration
    {
        public override void Up()
        {
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PickingInItem", "PickingIn_Id", "dbo.PickingIn");
            DropForeignKey("dbo.PickingInItem", "Literaure_Id", "dbo.Literature");
            DropIndex("dbo.PickingInItem", new[] { "Literaure_Id" });
            DropIndex("dbo.PickingInItem", new[] { "PickingIn_Id" });
            DropTable("dbo.PickingInItem");
        }
    }
}
