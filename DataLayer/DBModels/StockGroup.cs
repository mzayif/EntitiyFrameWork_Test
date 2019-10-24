using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DBModels
{
    public class StockGroup:BaseDB
    {
        [StringLength(50)]
        public string StockGroupName { get; set; }
        public virtual ICollection<StockType> StockTypes { get; set; }
    }
}
