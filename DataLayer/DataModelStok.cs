namespace DataLayer
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using DataLayer.DBModels;

    public partial class DataModelStok : DbContext
    {
        private string GetConnectionPoints(int cp)
        {
            string ConnStr = "";
            switch (cp)
            {
                case -61:
                    { // AVIO Kurallar Ba�lant�s�
                        ConnStr = "Data Source=94.73.135.2;Initial Catalog=AVIOSettings;User Id=sa; password=�Lif6134"; break;
                    }
                case -6:
                    { // AYARLAR VE TANIMLAR �n merkezi bir noktadan y�netilmesi i�in
                        ConnStr = "Data Source=94.73.135.2;Initial Catalog=icra;User Id=sa; password=�Lif6134";
                        break;
                    }
                case -5:
                    { // UYAP DOSYA �rne�i DB Ba�lant�s�  BU DB �ste�e g�re daha sonradan Ayr�labilir.
                        ConnStr = "Data Source=94.73.135.2;Initial Catalog=icra;User Id=sa; password=�Lif6134";
                        break;
                    }
                case -4:
                    { // LOG DB Ba�lant�s�
                        ConnStr = "Data Source=94.73.135.2;Initial Catalog=AVIOLog;User Id=sa; password=�Lif6134";
                        break;
                    }
                case -3:
                    { // Geli�tirme Ba�lant�s�
                        ConnStr = "Data Source=94.73.135.2;Initial Catalog=icraX_Gelistirme;User Id=sa; password=�Lif6134";
                        break;
                    }
                case -1:
                    { // Merkez Ba�lant�s�
                        ConnStr = "Data Source=94.73.135.2;Initial Catalog=icra;User Id=sa; password=�Lif6134";
                        break;
                    }
                case 2:
                    { // icraXSorgu Gibi Di�er Programlar�n Giri� Bilgilerini Kaydeder

                        //ConnStr = "Data Source=94.73.135.2;Initial Catalog=IcraxKatip;User Id=Katip; password=icrax!@sha"; break;
                        ConnStr = "Data Source=94.73.135.2;Initial Catalog=ROBOKATIP;User Id=sa; password=�Lif6134";
                        break;
                    }
                // Demo ve Test Hesaplar� �irket b�nyesinde 
                case -2: ConnStr = "Data Source=94.73.135.2;Initial Catalog=AVIOTest;User Id=sa; password=�Lif6134"; break; //Genel Olarak M�vekkil Kullan�c�lar� Banka Demosu i�in Teste Aktar�ld�.
                case 1: ConnStr = "Data Source=94.73.135.2;Initial Catalog=AVIOTest;User Id=sa; password=�Lif6134"; break;
                case 4: ConnStr = "Data Source=94.73.135.2;Initial Catalog=AVIOTest;User Id=sa; password=�Lif6134"; break;
                case 6: ConnStr = "Data Source=94.73.135.2;Initial Catalog=AVIOTest;User Id=sa; password=�Lif6134"; break;
                case 7: ConnStr = "Data Source=94.73.135.2;Initial Catalog=AVIOTest;User Id=sa; password=�Lif6134"; break;
                case 8: ConnStr = "Data Source=94.73.135.2;Initial Catalog=AVIOTest;User Id=sa; password=�Lif6134"; break;
                case 9: ConnStr = "Data Source=94.73.135.2;Initial Catalog=AVIOTest;User Id=sa; password=�Lif6134"; break;
                case 10: ConnStr = "Data Source=94.73.135.2;Initial Catalog=AVIOTest;User Id=sa; password=�Lif6134"; break;
                case 11: ConnStr = "Data Source=94.73.135.2;Initial Catalog=AVIOTest;User Id=sa; password=�Lif6134"; break;
                case 1006: ConnStr = "Data Source=94.73.135.2;Initial Catalog=AVIOTest;User Id=sa; password=�Lif6134"; break;
                case 1007: ConnStr = "Data Source=94.73.135.2;Initial Catalog=AVIOTest;User Id=sa; password=�Lif6134"; break;
                case 1011: ConnStr = "Data Source=94.73.135.2;Initial Catalog=AVIOTest;User Id=sa; password=�Lif6134"; break;
                case 2783: ConnStr = "Data Source=94.73.135.2;Initial Catalog=AVIOTest;User Id=sa; password=�Lif6134"; break;
                case 6092: ConnStr = "Data Source=94.73.135.2;Initial Catalog=AVIOTest;User Id=sa; password=�Lif6134"; break;
                case 7107: ConnStr = "Data Source=94.73.135.2;Initial Catalog=AVIOTest;User Id=sa; password=�Lif6134"; break;

                case 1000:
                    { // Demo
                        ConnStr = "Data Source=192.168.3.3;Initial Catalog=icra;User Id=sa; password=�Lif6134"; break;
                    }
                case 3978:
                    { // Aksen hukuk
                        //ConnStr = "Data Source=192.168.2.190;Initial Catalog=icra;User Id=DbtX; password=AsK@15_Db"; // icraX Aktar ve Sorgu ��in
                        ConnStr = "Data Source=213.74.135.26;Initial Catalog=icra;User Id=DbtX; password=AsK@15_Db"; break;
                    }
                case 4017:
                    { // MHG ��in                        
                      //ConnStr = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=icra;User Id=sa; password=AsK@15_Db*"; break; // Yerel
                        ConnStr = @"Data Source=176.40.49.170,6162;Initial Catalog=icra;User Id=sa; password=AsK@15_Db*"; break; // Uzak
                    }
                case 13214:
                    { // B�y�kkaya hukuk
                        //ConnStr = @"Data Source=(local);Initial Catalog=AVIO_Buyukkaya;User Id=sa; password=AsK@18_Yk!01"; break;//B�y�kkaya Yerel ��in
                        ConnStr = @"Data Source=31.145.30.58,6162;Initial Catalog=AVIO_Buyukkaya;User Id=sa; password=AsK@18_Yk!01"; break;//B�y�kkaya Uzaktan Ba�lant� ��in
                    }
                case 13304:
                    { // �LHAN & DUMAN hukuk
                        //ConnStr = @"Data Source=(local);Initial Catalog=AVIO_IlhanDuman;User Id=sa; password=AsK@18_Yk!01"; break;//�LHAN DUMAN Yerel ��in
                        ConnStr = @"Data Source=94.73.135.2;Initial Catalog=AVIO_IlhanDuman;User Id=sa; password=�Lif6134"; break;//�LHAN DUMAN Uzak Ba�lant� ��in                        
                    }
                default:
                    {
                        //ConnStr = @"Data Source=(local);Initial Catalog=AVIO_Buyukkaya;User Id=sa; password=AsK@18_Yk!01";//B�y�kkaya Yerel ��in
                        //ConnStr = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=icra;User Id=sa; password=AsK@15_Db*";//MHG Yerel ��in
                        //ConnStr = "Data Source=(local);Initial Catalog=icra;User Id=sa; password=�Lif6134";// Server Ana SQL
                        ConnStr = "Data Source=94.73.135.2;Initial Catalog=icra;User Id=sa; password=�Lif6134";
                        break;
                    }
            }


            return ConnStr;
        }

        public DataModelStok()
            : base("name=StokDataModel")
        {
        }

        public virtual DbSet<Personel> Personel { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Departman> Departman { get; set; }
        //public virtual DbSet<StokTipleri> Stoks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
