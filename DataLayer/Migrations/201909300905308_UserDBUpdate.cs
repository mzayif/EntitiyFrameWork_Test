namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserDBUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "NAME", c => c.String());
            AddColumn("dbo.Users", "SURENAME", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "SURENAME");
            DropColumn("dbo.Users", "NAME");
        }
    }
}
