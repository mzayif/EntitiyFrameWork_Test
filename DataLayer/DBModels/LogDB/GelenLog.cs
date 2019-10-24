using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DBModels.LogDB
{
    public class GelenLog
    {
        public int GelenLogId { get; set; }
        public int IslemTuru { get; set; }
        public string IsParcacigi { get; set; }
        public int IslemYapilanKayitId { get; set; }
        public int KullaniciId { get; set; }
        public string BaglantiAnahtari { get; set; }
        public string KullaniciBilgileri { get; set; }
        public string IpAdresi { get; set; }
        public DateTime IslemBaslamaTarihi { get; set; }
        public string GelenBilgi { get; set; }

    }
}
