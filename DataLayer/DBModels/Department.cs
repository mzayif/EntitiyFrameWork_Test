namespace DataLayer.DBModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;


    public partial class Department:BaseDBModel
    {

        public Department()
        {
            Personel = new HashSet<Personel>();
        }

        [StringLength(50)]
        public string DepartmentName { get; set; }
        public int DepartmentType { get; set; }

        public virtual ICollection<Personel> Personel { get; set; }
    }
}
