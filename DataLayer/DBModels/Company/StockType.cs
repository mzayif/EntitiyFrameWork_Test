
namespace DataLayer.DBModels
{
    using DataLayer.Enums;
    using System.ComponentModel.DataAnnotations;

    public class StockType : BaseDBModel
    {
        [StringLength(50)]
        public string StockName { get; set; }
        public StockGroup StockGroup { get; set; }
        public UnitType UnitType { get; set; }
        [StringLength(10)]
        public string Code { get; set; }
        public int MinCount { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
        public int KarOrani { get; set; }
        public CurrencyType BuyingCurrencyType { get; set; }
        public CurrencyType SaleCurrencyType { get; set; }
        public decimal TaxRate { get; set; }
        [StringLength(20)]
        public string Barcode { get; set; }
        [StringLength(100)]
        public string DefinitionName { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
    }
}