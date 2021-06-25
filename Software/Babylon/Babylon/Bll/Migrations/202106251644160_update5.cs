namespace Bll.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update5 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PickingOutItem", "Literature_Id", "dbo.Literature");
            DropForeignKey("dbo.PickingOutItem", "PickingOut_Id", "dbo.PickingOut");
            DropIndex("dbo.PickingOutItem", new[] { "PickingOut_Id" });
            DropIndex("dbo.PickingOutItem", new[] { "Literature_Id" });
            AddColumn("dbo.PickingOut", "Description", c => c.String());
            DropTable("dbo.PickingOutItem");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.PickingOutItem",
                c => new
                    {
                        PickingOut_Id = c.Int(nullable: false),
                        Literature_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.PickingOut_Id, t.Literature_Id });
            
            DropColumn("dbo.PickingOut", "Description");
            CreateIndex("dbo.PickingOutItem", "Literature_Id");
            CreateIndex("dbo.PickingOutItem", "PickingOut_Id");
            AddForeignKey("dbo.PickingOutItem", "PickingOut_Id", "dbo.PickingOut", "Id", cascadeDelete: true);
            AddForeignKey("dbo.PickingOutItem", "Literature_Id", "dbo.Literature", "Id", cascadeDelete: true);
        }
    }
}
