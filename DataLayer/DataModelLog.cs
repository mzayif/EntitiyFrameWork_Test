using DataLayer.DBModels.LogDB;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    
    public partial class DataModelLog : DbContext
    {
        public DataModelLog()
           : base("name=LogDataModel")
        {

        }
        public virtual DbSet<GelenLog> GelenLoglar { get; set; }
        public virtual DbSet<GidenLog> GidenLoglar { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}
