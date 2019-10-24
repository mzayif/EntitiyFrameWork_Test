namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StockGroupTableAdd : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StockGroups",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        StockGroupName = c.String(maxLength: 50),
                        CreateDate = c.DateTime(nullable: false),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            AddColumn("dbo.StockTypes", "StockGroup_id", c => c.Int());
            CreateIndex("dbo.StockTypes", "StockGroup_id");
            AddForeignKey("dbo.StockTypes", "StockGroup_id", "dbo.StockGroups", "id");
            DropColumn("dbo.StockTypes", "StockCount");
        }
        
        public override void Down()
        {
            AddColumn("dbo.StockTypes", "StockCount", c => c.Int(nullable: false));
            DropForeignKey("dbo.StockTypes", "StockGroup_id", "dbo.StockGroups");
            DropIndex("dbo.StockTypes", new[] { "StockGroup_id" });
            DropColumn("dbo.StockTypes", "StockGroup_id");
            DropTable("dbo.StockGroups");
        }
    }
}
