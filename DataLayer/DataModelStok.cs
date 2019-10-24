namespace DataLayer
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using DataLayer.DBModels;

    public partial class DataModelStok : DbContext
    {
        
        public DataModelStok()
            : base("name=StokDataModel")
        {
        }

        public virtual DbSet<Personel> Personel { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Departman> Departman { get; set; }
        //public virtual DbSet<StokTipleri> Stoks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
