using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public partial class DataModelSetting : DbContext
    {
        public DataModelSetting(string ConnectionPoint)
           : base(ConnectionPoint)
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}
