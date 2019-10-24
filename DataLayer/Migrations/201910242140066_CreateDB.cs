namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        DepartmentName = c.String(maxLength: 50),
                        DepartmentType = c.Int(nullable: false),
                        CancelDate = c.DateTime(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        Active = c.Boolean(nullable: false),
                        CancelUser_id = c.Int(),
                        CreateUser_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Users", t => t.CancelUser_id)
                .ForeignKey("dbo.Users", t => t.CreateUser_id)
                .Index(t => t.CancelUser_id)
                .Index(t => t.CreateUser_id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surename = c.String(),
                        UserName = c.String(),
                        Password = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        Active = c.Boolean(nullable: false),
                        Personel_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Personels", t => t.Personel_id)
                .Index(t => t.Personel_id);
            
            CreateTable(
                "dbo.Personels",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Surname = c.String(maxLength: 50),
                        Salary = c.Short(),
                        BirthDay = c.DateTime(storeType: "smalldatetime"),
                        Gender = c.Boolean(nullable: false),
                        Married = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        Active = c.Boolean(nullable: false),
                        Department_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Departments", t => t.Department_id)
                .Index(t => t.Department_id);
            
            CreateTable(
                "dbo.StockTypes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        StockName = c.String(maxLength: 50),
                        StockCount = c.Int(nullable: false),
                        CancelDate = c.DateTime(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        Active = c.Boolean(nullable: false),
                        CancelUser_id = c.Int(),
                        CreateUser_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Users", t => t.CancelUser_id)
                .ForeignKey("dbo.Users", t => t.CreateUser_id)
                .Index(t => t.CancelUser_id)
                .Index(t => t.CreateUser_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StockTypes", "CreateUser_id", "dbo.Users");
            DropForeignKey("dbo.StockTypes", "CancelUser_id", "dbo.Users");
            DropForeignKey("dbo.Departments", "CreateUser_id", "dbo.Users");
            DropForeignKey("dbo.Departments", "CancelUser_id", "dbo.Users");
            DropForeignKey("dbo.Users", "Personel_id", "dbo.Personels");
            DropForeignKey("dbo.Personels", "Department_id", "dbo.Departments");
            DropIndex("dbo.StockTypes", new[] { "CreateUser_id" });
            DropIndex("dbo.StockTypes", new[] { "CancelUser_id" });
            DropIndex("dbo.Personels", new[] { "Department_id" });
            DropIndex("dbo.Users", new[] { "Personel_id" });
            DropIndex("dbo.Departments", new[] { "CreateUser_id" });
            DropIndex("dbo.Departments", new[] { "CancelUser_id" });
            DropTable("dbo.StockTypes");
            DropTable("dbo.Personels");
            DropTable("dbo.Users");
            DropTable("dbo.Departments");
        }
    }
}
