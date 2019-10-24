
namespace DataLayer.DBModels
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class StockType : BaseDBModel
    {
        [StringLength(50)]
        public string StockName { get; set; }
        public StockGroup StockGroup { get; set; }
    }
}