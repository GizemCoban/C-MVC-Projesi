using Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager
{
    public static class DataSqlQuestion
    {
        /*, public static DataSet GetEmployee(string accessKey)
        {
            using (DbManager dbManager = new DbManager(Security.GetConnStrFromAccessKey(accessKey)))
            {
                string sql = @"Select * From ViewEmployee where FirmaID=" + accessKey.ToInt32();
               
                return dbManager.GetDataSet(sql);
            }
        }
         */
        public static DataTable GetYonetici(int accessKey)
        {
            using (DbManager dbManager = new DbManager(Sessions.ConnectionStringSql))
            {
                string sql = @"Select * From tblYetki where YetkiID=" + accessKey;

                return dbManager.GetDataTable(sql);
            }
        }
        #region Yönetici
        public static DataTable GetYoneticiKontrol(string KAdi, string Sifre)
        {
            using (DbManager dbManager = new DbManager(Sessions.ConnectionStringSql))
            {

                string sql = @"Select * From tblYonetici where KullaniciAdi='" + KAdi + "' and Sifre='" + Sifre + "'";

                return dbManager.GetDataTable(sql);

            }
        }

        #endregion
        public static bool SetDogru(string Cevap, int SoruID)
        {
            using (DbManager dbManager = new DbManager(Sessions.ConnectionStringSql))
            {
                string sql = @"insert into tblDogruCevap(SoruID,Cevap)values(@SoruID,@Cevap)";
                dbManager.DataCommand.Parameters.Add("@SoruID", SqlDbType.Int).Value = SoruID;
                dbManager.DataCommand.Parameters.Add("@Cevap", SqlDbType.VarChar).Value = Cevap;

                dbManager.RunCommand(sql);
                return dbManager.CommitTransaction();

            }

        }

        public static DataTable GetSoruSayisi()
        {
            throw new NotImplementedException();
        }

        public static DataTable GetSoruGetir(int Oturum, int Sira)
        {
            using (DbManager dbManager = new DbManager(Sessions.ConnectionStringSql))
            {

                string sql = @"Select * From tblSoru where OturumID=" + Oturum + " and SoruSirasi=" + Sira;
                return dbManager.GetDataTable(sql);
            }
        }
        public static DataTable GetSecenekGetir(int soruid)
        {
            using (DbManager dbManager = new DbManager(Sessions.ConnectionStringSql))
            {

                string sql = @"Select * From tblSCevap where SoruID=" + soruid;
                return dbManager.GetDataTable(sql);
            }
        }
        public static DataTable GetBoslukGetir(int soruid)
        {
            using (DbManager dbManager = new DbManager(Sessions.ConnectionStringSql))
            {

                string sql = @"Select * From tblBCevap where SoruID=" + soruid;
                return dbManager.GetDataTable(sql);
            }
        }

        public static DataTable SetDogru(object cevap, int soruID)
        {
            throw new NotImplementedException();
        }




        #region Öğretmen 
        //Öğretmen tablosundan öğretmenin kullanıcı adı ve şifresini aldığımız kısım.
        public static DataTable GetOgretmenKontrol(string KAdi, string Sifre)
        {
            using (DbManager dbManager = new DbManager(Sessions.ConnectionStringSql))
            {

                string sql = @"Select * From tblOgretmen where KullaniciAdi='" + KAdi + "' and Sifre='" + Sifre + "'";
                return dbManager.GetDataTable(sql);
            }
        }

        /*
          public static bool UrunAdd(Model.Elif.Urun tblUrun)
        {
            using (DbManagerAccess dbManager = new DbManagerAccess(Sessions.ConnectionStringAccess))
            {
                string sql = @"insert into tblUrun(UrunAdi,Tutar,Barcode,Miktar,BirimFiyati,KDVID,ToplamTutar,Doviz,BirimID,KDVFiyat)values(@UrunAdi,@Tutar,@Barcode,@Miktar,@BirimFiyati,@KDVID,@ToplamTutar,@Doviz,@BirimID,@KDVFiyat)";
                dbManager.DataCommand.Parameters.Add("@UrunAdi", SqlDbType.VarChar).Value = tblUrun.UrunAdi;
                dbManager.DataCommand.Parameters.Add("@Tutar", SqlDbType.Float).Value = tblUrun.tutar;
                dbManager.RunCommand(sql);
                return dbManager.CommitTransaction();
          
         */
        public static bool OgretmenEkle(Model.Values.Ogretmen Ogrt)
        {
            using (DbManager dbManager = new DbManager(Sessions.ConnectionStringSql))
            {
                string sql = @"insert into tblOgretmen(KullaniciAdi,KullaniciSoyadi,Sifre)values(@KullaniciAdi,@KullaniciSoyadi,@Sifre)";
                dbManager.DataCommand.Parameters.Add("@KullaniciAdi", SqlDbType.VarChar).Value = Ogrt.OgretmenAdi;
                dbManager.DataCommand.Parameters.Add("@KullaniciSoyadi", SqlDbType.VarChar).Value = Ogrt.OgretmenSoyadi;
                dbManager.DataCommand.Parameters.Add("@Sifre", SqlDbType.VarChar).Value = Ogrt.Sifre;

                dbManager.RunCommand(sql);
                return dbManager.CommitTransaction();

            }

        }


        #endregion

        #region Ögrenci

        public static DataTable GetOgrenciKontrol(string KAdi, string Sifre)
        {
            using (DbManager dbManager = new DbManager(Sessions.ConnectionStringSql))
            {

                string sql = @"Select * From tblOgrenci where KullaniciAdi='" + KAdi + "' and Sifre='" + Sifre + "'";
                return dbManager.GetDataTable(sql);
            }
        }

        #endregion
        #region Oturum
        // SetOturumEkle

        public static bool SetOturumEkle(Model.Values.Oturum Otr)
        {
            using (DbManager dbManager = new DbManager(Sessions.ConnectionStringSql))
            {
                string sql = @"insert into tblOturum(OgretmenID,OturumAdi,Sifre,BaslangicTarihi,BitisTarihi,Sure)values(@OgretmenID,@OturumAdi,@Sifre,@BaslangicTarihi,@BitisTarihi,@Sure)";
                dbManager.DataCommand.Parameters.Add("@OgretmenID", SqlDbType.Int).Value = Sessions.KullaniciID;
                dbManager.DataCommand.Parameters.Add("@OturumAdi", SqlDbType.VarChar).Value = Otr.OturumAdi;
                dbManager.DataCommand.Parameters.Add("@Sifre", SqlDbType.VarChar).Value = Otr.OturumSifre;
                dbManager.DataCommand.Parameters.Add("@BaslangicTarihi", SqlDbType.DateTime).Value = Otr.OturumBaslangicTarihi;
                dbManager.DataCommand.Parameters.Add("@BitisTarihi", SqlDbType.DateTime).Value = Otr.OturumBitisTarihi;
                dbManager.DataCommand.Parameters.Add("@Sure", SqlDbType.DateTime).Value = Otr.OturumSuresi;

                dbManager.RunCommand(sql);
                return dbManager.CommitTransaction();

            }

        }
        public static DataTable GetOturumList()
        {
            using (DbManager dbManager = new DbManager(Sessions.ConnectionStringSql))
            {
                string sql = @"Select * From tblOturum where OgretmenID=" + Sessions.KullaniciID + " and SilindiMi=0";

                return dbManager.GetDataTable(sql);
            }
        }
        #endregion

        //son soruyu alır.
        public static DataTable SetSoruID(int Oturum)
        {
            using (DbManager dbManager = new DbManager(Sessions.ConnectionStringSql))
            {

                string sql = @"SELECT  top 1* FROM tblSoru where OturumID=" + Oturum + " ORDER BY SoruID DESC";

                return dbManager.GetDataTable(sql);

            }
        }
        public static DataTable ToplamPuan(int Oturum)
        {
            using (DbManager dbManager = new DbManager(Sessions.ConnectionStringSql))
            {

                string sql = @"SELECT  Sum(Puan) as Puan FROM tblSoru where OturumID=" + Oturum + " and SilindiMi=0";

                return dbManager.GetDataTable(sql);

            }
        }
        public static DataTable SoruSayi(int Oturum)
        {
            using (DbManager dbManager = new DbManager(Sessions.ConnectionStringSql))
            {

                string sql = @"SELECT  top 1* FROM tblSoru where OturumID=" + Oturum + " ORDER BY SoruSirasi DESC";

                return dbManager.GetDataTable(sql);

            }
        }


        #region Soru Ekleme
        //Soru tablosundan gerekli alanları alarak soru ekleme işlemi yapılmaktadır. 

        public static DataTable SetSoruEkle(Model.Values.Soru Soru, int OturumID)
        {
            using (DbManager dbManager = new DbManager(Sessions.ConnectionStringSql))
            {
                string sql = @"insert into tblSoru(SoruAdi,SoruTuru,OturumID,SoruSirasi,Puan)values(@SoruAdi,@SoruTuru,@OturumID,@SoruSirasi,@Puan)";
                dbManager.DataCommand.Parameters.Add("@SoruAdi", SqlDbType.VarChar).Value = Soru.SoruAdi;
                dbManager.DataCommand.Parameters.Add("@SoruTuru", SqlDbType.Bit).Value = Soru.SoruTuru;
                dbManager.DataCommand.Parameters.Add("@OturumID", SqlDbType.Int).Value = OturumID;
                dbManager.DataCommand.Parameters.Add("@SoruSirasi", SqlDbType.TinyInt).Value = Soru.SoruSirasi;
                dbManager.DataCommand.Parameters.Add("@Puan", SqlDbType.TinyInt).Value = Soru.Puan;

                return dbManager.GetDataTable(sql);

            }
        }
        //Oturum Sildirme İşlemi
        public static DataTable SetOturumSil(int id)
        {
            using (DbManager dbManager = new DbManager(Sessions.ConnectionStringSql))
            {
                string sql = @"Update tblOturum Set SilindiMi=1 where  OturumID=" + id;
                return dbManager.GetDataTable(sql);
            }
        }
        /*
        public static DataTable SetOturumGuncelle()
        {
            using (DbManager dbManager = new DbManager(Sessions.ConnectionStringSql))
            {
                string sql = @"Update tblOturum Set OturumAdi,Sifre,OlusturlmaTarihi,BaslangicTarihi,BitisTarihi,Sure where SilindiMi=1";
                //string sql

                return dbManager.GetDataTable(sql);
            }
        }
        */


        //Soruları güncelleme

        public static DataTable SetSoruGuncelle(int SoruID, Model.Values.Soru Soru)
        {
            using (DbManager dbManager = new DbManager(Sessions.ConnectionStringSql))
            {
                string sql = @"Update tblSoru Set SoruAdi=@SoruAdi,Puan=@Puan where SoruID=" + SoruID;
                dbManager.DataCommand.Parameters.Add("@SoruAdi", SqlDbType.VarChar).Value = Soru.SoruAdi;
                dbManager.DataCommand.Parameters.Add("@Puan", SqlDbType.TinyInt).Value = Soru.Puan;

                return dbManager.GetDataTable(sql);

            }
        }
        //Şıklı sorularda şıklara veri girme işlemi yapmak.
        public static DataTable SetSecenekEkle(Model.Values.Soru Soru, int SoruID)
        {
            using (DbManager dbManager = new DbManager(Sessions.ConnectionStringSql))
            {
                string sql = @"insert into tblSCevap(SoruID,A,B,C,D,E)values(@SoruID,@A,@B,@C,@D,@E)";
                dbManager.DataCommand.Parameters.Add("@SoruID", SqlDbType.Int).Value = SoruID;
                dbManager.DataCommand.Parameters.Add("@A", SqlDbType.VarChar).Value = Soru.SecenekA;
                dbManager.DataCommand.Parameters.Add("@B", SqlDbType.VarChar).Value = Soru.SecenekB;
                dbManager.DataCommand.Parameters.Add("@C", SqlDbType.VarChar).Value = Soru.SecenekC;
                dbManager.DataCommand.Parameters.Add("@D", SqlDbType.VarChar).Value = Soru.SecenekD;
                dbManager.DataCommand.Parameters.Add("@E", SqlDbType.VarChar).Value = Soru.SecenekE;
                return dbManager.GetDataTable(sql);

            }

        }
        #region Boşluk Doldurma Ekleme
        public static DataTable SetBoslukEkle(string Soru, int SoruID)
        {
            using (DbManager dbManager = new DbManager(Sessions.ConnectionStringSql))
            {
                string sql = @"insert into tblBCevap(SoruID,BCevap)values(@SoruID,@BCevap)";
                dbManager.DataCommand.Parameters.Add("@SoruID", SqlDbType.Int).Value = SoruID;
                dbManager.DataCommand.Parameters.Add("@BCevap", SqlDbType.VarChar).Value = Soru;

                return dbManager.GetDataTable(sql);

            }

        }
        #endregion




        #endregion
        #region Öğrenci Ekleme
        public static bool OgrenciEkle(Model.Values.Ogrenci Ogrc)
        {
            using (DbManager dbManager = new DbManager(Sessions.ConnectionStringSql))
            {
                string sql = @"insert into tblOgrenci(KullaniciAdi,KullaniciSoyadi,Sifre)values(@KullaniciAdi,@KullaniciSoyadi,@Sifre)";
                dbManager.DataCommand.Parameters.Add("@KullaniciAdi", SqlDbType.VarChar).Value = Ogrc.OgrenciAdi;
                dbManager.DataCommand.Parameters.Add("@KullaniciSoyadi", SqlDbType.VarChar).Value = Ogrc.OgrenciSoyadi;
                dbManager.DataCommand.Parameters.Add("@Sifre", SqlDbType.VarChar).Value = Ogrc.Sifre;

                dbManager.RunCommand(sql);
                return dbManager.CommitTransaction();

            }

        }


        #endregion
        #region Öğrenci Oturuma Giriş
        public static DataTable OgrenciOturum(string OturumAdi)
        {
            using (DbManager dbManager = new DbManager(Sessions.ConnectionStringSql))
            {
                string sql = @"Select*From tblOturum Where OturumAdi='" + OturumAdi + "'";

                return dbManager.GetDataTable(sql);


            }

        }

        //Toplam kaç sorumuz var onu çekiyoruz. FrmSorularda bu sorguyu çağırıp her seferinde SoruSirasi değişkenini arttırıyoruz.

        public static DataTable GetSoruSayisi(int OturumID, int SoruSirasi)
        {
            using (DbManager dbManager = new DbManager(Sessions.ConnectionStringSql))
            {
                string sql = @"Select*From tblSoru Where OturumID=" + OturumID + "and SoruSirasi=" + SoruSirasi;

                return dbManager.GetDataTable(sql);


            }

        }

        public static DataTable DogruCevabiGonder(int SoruID, string Cevap)
        {
            using (DbManager dbManager = new DbManager(Sessions.ConnectionStringSql))
            {
                string sql = @"Select*From tblDogruCevap Where SoruID=" + SoruID + "and Cevap='" + Cevap + "'";

                return dbManager.GetDataTable(sql);


            }

        }
        
        
        public static DataTable BoslukDogruCevabiGonder(int SoruID, string BCevap)
        {
            using (DbManager dbManager = new DbManager(Sessions.ConnectionStringSql))
            {
                string sql = @"Select*From tblBCevap Where SoruID=" + SoruID + "and BCevap='" + BCevap + "'";

                return dbManager.GetDataTable(sql);


            }
            

        }






        #endregion
        /*
        #region Soruları Öğrencilere Gösterme
        public static DataTable(string OturumAdi)
        {
            using (DbManager dbManager = new DbManager(Sessions.ConnectionStringSql))
            {
                string sql = @"Select*From tblOturum Where OturumID" + OturumAdi;

                return dbManager.GetDataTable(sql);


            }

        }
        */
        
        public static bool NotlariEkle(int OturumID, int OgrenciID,int toplamPuan)
        {
            using (DbManager dbManager = new DbManager(Sessions.ConnectionStringSql))
            {
                string sql = @"insert into tblSonuc(OturumID,OgrenciID,ToplamPuan)values(@OturumID,@OgrenciID,@toplamPuan)";
                dbManager.DataCommand.Parameters.Add("@OturumID", SqlDbType.Int).Value = OturumID;
                dbManager.DataCommand.Parameters.Add("@OgrenciID", SqlDbType.Int).Value = OgrenciID;
                dbManager.DataCommand.Parameters.Add("@toplamPuan", SqlDbType.Int).Value =toplamPuan;

                dbManager.RunCommand(sql);
                return dbManager.CommitTransaction();

            }

        }

        
        #region Notları Listele
        public static DataTable GetNotlarListesi(int sonucid)
        {
            using (DbManager dbManager = new DbManager(Sessions.ConnectionStringSql))
            {

                string sql = @"Select * From tblSonuc where SonucID=" + sonucid;
                return dbManager.GetDataTable(sql);
            }
        }

        #endregion

        
        
        public static DataTable GetExcellListesi(int oturumid)
        {
            using (DbManager dbManager = new DbManager(Sessions.ConnectionStringSql))
            {

                string sql = @"SELECT dbo.tblOgrenci.KullaniciAdi, dbo.tblOgrenci.KullaniciSoyadi, dbo.tblSonuc.ToplamPuan, dbo.tblSonuc.SonucID, dbo.tblOturum.OturumID AS Expr1, dbo.tblOgrenci.OgrenciID FROM dbo.tblOgrenci INNER JOIN
                         dbo.tblSonuc ON dbo.tblOgrenci.OgrenciID = dbo.tblSonuc.OgrenciID INNER JOIN
                         dbo.tblOturum ON dbo.tblSonuc.OturumID = dbo.tblOturum.OturumID WHERE  dbo.tblOturum.OturumID = " + oturumid;
                return dbManager.GetDataTable(sql);
            }
           
       }
       


    }
}

