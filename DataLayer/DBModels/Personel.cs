namespace DataLayer.DBModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Personel: BaseDB
    {
        [StringLength(50)]
        public string Ad { get; set; }

        [StringLength(50)]
        public string Soyad { get; set; }

        public short? Maas { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DogumTarihi { get; set; }

        public bool Gender { get; set; }

        public bool Married { get; set; }

        public virtual Departman Departman { get; set; }

        public Personel()
        {
            Ad = "";
            Soyad = "";
            Maas = 0;
            DogumTarihi = new DateTime(1900,1,1);
            Gender = true;
            Married = false;            
        }
    }
}
