namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedLoanDateReturnedProp : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Loan", "DateReturned", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Loan", "DateReturned");
        }
    }
}
