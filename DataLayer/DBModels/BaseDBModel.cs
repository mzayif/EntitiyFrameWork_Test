using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DBModels
{
    public class BaseDBModel: BaseDB
    {    

        public User CreateUser { get; set; }
        public DateTime CancelDate { get; set; }
        public User CancelUser { get; set; }
       

        public BaseDBModel()
        {
            CreateDate = DateTime.Now;            
            CancelDate = new DateTime(1900,1,1);            
        }
    }
}
