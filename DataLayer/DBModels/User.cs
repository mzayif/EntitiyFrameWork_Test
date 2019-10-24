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
        [Column(name: "NAME")]
        public string Name { get; set; }

        [Column(name: "SURENAME")]
        public string Surename { get; set; }

        [Column(name: "USER_NAME")]
        public string UserName { get; set; }

        [Column(name: "PASSWORD")]
        public string Password { get; set; }

        public virtual Personel Personel { get; set; }
    }
}
