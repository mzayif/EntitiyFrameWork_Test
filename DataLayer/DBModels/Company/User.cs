using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DBModels
{
    public class User : BaseDB
    {

        public string Name { get; set; }
        public string Surename { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public virtual Personel Personel { get; set; }
    }
}
