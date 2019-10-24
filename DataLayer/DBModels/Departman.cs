namespace DataLayer.DBModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;


    public partial class Departman:BaseDBModel
    {

        public Departman()
        {
            Personel = new HashSet<Personel>();
        }

        [StringLength(50)]
        public string Ad { get; set; }

        public virtual ICollection<Personel> Personel { get; set; }
    }
}
