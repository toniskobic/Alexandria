namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPasswordHashAndSaltToUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.User", "PasswordHash", c => c.String(maxLength: 255));
            AddColumn("dbo.User", "PasswordSalt", c => c.String(maxLength: 255));
            DropColumn("dbo.User", "Password");
        }
        
        public override void Down()
        {
            AddColumn("dbo.User", "Password", c => c.String());
            DropColumn("dbo.User", "PasswordSalt");
            DropColumn("dbo.User", "PasswordHash");
        }
    }
}
