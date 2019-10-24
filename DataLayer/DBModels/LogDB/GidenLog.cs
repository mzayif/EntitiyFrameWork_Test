using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DBModels.LogDB
{
    public class GidenLog
    {
        public int GidenLogId { get; set; }
        public int GelenLogId { get; set; }
        public int KullaniciId { get; set; }
        public string BaglantiAnahtari { get; set; }
        public DateTime SonuclanmaTarihi { get; set; }
        public int IslemSuresi { get; set; }
        public string GidenBilgi { get; set; }
        public int BasariDurumu { get; set; }
    }
}
