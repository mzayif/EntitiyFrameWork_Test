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

        public int id { get; set; }
        public DateTime CreateDate { get; set; } 
        public bool isActive { get; set; }

        public BaseDB()
        {
            CreateDate = DateTime.Now;
            this.isActive = true;
        }
    }
}
