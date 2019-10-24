
namespace DataLayer.DBModels
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class StokTipleri : BaseDBModel
    {
        [StringLength(50)]
        public string StokAdi { get; set; }
        public int StokAdeti { get; set; }
    }
}