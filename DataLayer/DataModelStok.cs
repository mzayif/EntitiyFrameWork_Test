namespace DataLayer
{
    using DataLayer.DBModels;
    using System.Data.Entity;

    public partial class DataModelStok : DbContext
    {

        public DataModelStok()
            : base("name=StokDataModel")
        {
        }

        public virtual DbSet<Personel> Personel { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Department> Departman { get; set; }
        public virtual DbSet<StockType> StockTypes { get; set; }
        public virtual DbSet<StockGroup> StockGroups { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
