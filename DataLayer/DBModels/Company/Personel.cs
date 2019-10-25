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
        public string Name { get; set; }
        [StringLength(50)]
        public string Surname { get; set; }
        public short? Salary { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? BirthDay { get; set; }
        public bool Gender { get; set; }
        public bool Married { get; set; }
        public virtual Department Department { get; set; }

        public Personel()
        {
            Name = "";
            Surname = "";
            Salary = 0;
            BirthDay = new DateTime(1900,1,1);
            Gender = true;
            Married = false;            
        }
    }
}
