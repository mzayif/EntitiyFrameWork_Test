namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Personels",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Ad = c.String(maxLength: 50),
                        Soyad = c.String(maxLength: 50),
                        Maas = c.Short(),
                        DogumTarihi = c.DateTime(storeType: "smalldatetime"),
                        Gender = c.Boolean(nullable: false),
                        Married = c.Boolean(nullable: false),
                        CREATE_DATE = c.DateTime(nullable: false),
                        ACTIVE = c.Boolean(nullable: false),
                        Departman_id = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Departmen", t => t.Departman_id)
                .Index(t => t.Departman_id);
            
            CreateTable(
                "dbo.Departmen",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Ad = c.String(maxLength: 50),
                        CANCEL_DATE = c.DateTime(nullable: false),
                        CREATE_DATE = c.DateTime(nullable: false),
                        ACTIVE = c.Boolean(nullable: false),
                        CancelUser_id = c.Int(),
                        CreateUser_id = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.CancelUser_id)
                .ForeignKey("dbo.Users", t => t.CreateUser_id)
                .Index(t => t.CancelUser_id)
                .Index(t => t.CreateUser_id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        USER_NAME = c.String(),
                        PASSWORD = c.String(),
                        CREATE_DATE = c.DateTime(nullable: false),
                        ACTIVE = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Personels", "Departman_id", "dbo.Departmen");
            DropForeignKey("dbo.Departmen", "CreateUser_id", "dbo.Users");
            DropForeignKey("dbo.Departmen", "CancelUser_id", "dbo.Users");
            DropIndex("dbo.Departmen", new[] { "CreateUser_id" });
            DropIndex("dbo.Departmen", new[] { "CancelUser_id" });
            DropIndex("dbo.Personels", new[] { "Departman_id" });
            DropTable("dbo.Users");
            DropTable("dbo.Departmen");
            DropTable("dbo.Personels");
        }
    }
}
