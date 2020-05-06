using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Values
    {
        #region
        public class Ogretmen
        {
            public int OgretmenID { get; set; }
            public string OgretmenAdi { get; set; }
            public string OgretmenSoyadi{ get; set; }

            public string Sifre { get; set; }


            


        }
        #endregion 
        #region Oturum Ekranı
        public class Oturum
        {
            public string OturumAdi { get; set; }
            public string OturumSifre { get; set; }
            public DateTime OturumTarihi { get; set; }
            public string OturumBaslangicTarihi { get; set; }
            public string OturumBitisTarihi { get; set; }
            public string OturumSuresi { get; set; }

        }
        #endregion

        #region Öğrenci
        public class Ogrenci
        {
            public int OgrenciID { get; set; }
            public string OgrenciAdi { get; set; }
            public string OgrenciSoyadi { get; set; }
            public string Sifre { get; set; }

        }
        #endregion
        #region Şıklı soru 
        public class Soru
        {
            public int SoruID { get; set; }
            public string SoruAdi { get; set; }
            public string SecenekA { get; set; }
            public string SecenekB { get; set; }
            public string SecenekC { get; set; }
            public string SecenekD { get; set; }
            public string SecenekE { get; set; }
            public int SoruSirasi { get; set; }
            public bool SoruTuru { get; set; }
            public string Bosluk { get; set; }
            public int Puan { get; set; }
        }

        #endregion
        /*
        #region

        public class Bosluk
        {
            public int SoruID { get; set; }
            public string SoruAdi { get; set; }
            public string SecenekA { get; set; }
            public string SecenekB { get; set; }
            public string SecenekC { get; set; }
            public string SecenekD { get; set; }
            public string SecenekE { get; set; }
            public int SoruSirasi { get; set; }
            public bool SoruTuru { get; set; }
            public string Bosluk { get; set; }
            public int Puan { get; set; }
        }


        #endregion
    */


    }
}
