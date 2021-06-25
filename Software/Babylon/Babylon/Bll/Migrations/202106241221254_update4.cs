namespace Bll.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Role", "Name", c => c.String());
            DropColumn("dbo.Role", "RoleName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Role", "RoleName", c => c.String());
            DropColumn("dbo.Role", "Name");
        }
    }
}
