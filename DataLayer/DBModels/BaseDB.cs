using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DBModels
{
    public class BaseDB
    {
        [Column(name: "ID")]
        public int id { get; set; }

        [Column(name: "CREATE_DATE")]
        public DateTime CreateDate { get; set; }
        
        [Column(name: "ACTIVE")]
        public bool isActive { get; set; }

        public BaseDB()
        {
            CreateDate = DateTime.Now;
            this.isActive = true;
        }
    }
}
