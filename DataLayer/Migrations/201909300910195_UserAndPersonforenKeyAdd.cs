namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserAndPersonforenKeyAdd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Personel_id", c => c.Int());
            CreateIndex("dbo.Users", "Personel_id");
            AddForeignKey("dbo.Users", "Personel_id", "dbo.Personels", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "Personel_id", "dbo.Personels");
            DropIndex("dbo.Users", new[] { "Personel_id" });
            DropColumn("dbo.Users", "Personel_id");
        }
    }
}
