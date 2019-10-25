namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StockTypeTable_Update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StockTypes", "UnitType", c => c.Int(nullable: false));
            AddColumn("dbo.StockTypes", "Code", c => c.String(maxLength: 10));
            AddColumn("dbo.StockTypes", "MinCount", c => c.Int(nullable: false));
            AddColumn("dbo.StockTypes", "PurchasePrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.StockTypes", "SalePrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.StockTypes", "KarOrani", c => c.Int(nullable: false));
            AddColumn("dbo.StockTypes", "BuyingCurrencyType", c => c.Int(nullable: false));
            AddColumn("dbo.StockTypes", "SaleCurrencyType", c => c.Int(nullable: false));
            AddColumn("dbo.StockTypes", "TaxRate", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.StockTypes", "Barcode", c => c.String(maxLength: 20));
            AddColumn("dbo.StockTypes", "DefinitionName", c => c.String(maxLength: 100));
            AddColumn("dbo.StockTypes", "Description", c => c.String(maxLength: 500));
        }
        
        public override void Down()
        {
            DropColumn("dbo.StockTypes", "Description");
            DropColumn("dbo.StockTypes", "DefinitionName");
            DropColumn("dbo.StockTypes", "Barcode");
            DropColumn("dbo.StockTypes", "TaxRate");
            DropColumn("dbo.StockTypes", "SaleCurrencyType");
            DropColumn("dbo.StockTypes", "BuyingCurrencyType");
            DropColumn("dbo.StockTypes", "KarOrani");
            DropColumn("dbo.StockTypes", "SalePrice");
            DropColumn("dbo.StockTypes", "PurchasePrice");
            DropColumn("dbo.StockTypes", "MinCount");
            DropColumn("dbo.StockTypes", "Code");
            DropColumn("dbo.StockTypes", "UnitType");
        }
    }
}
