using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
   public static class Sessions
    {
        //Programa Giris Yapan Kullanıcı
        public static string ConnectionStringSql{ get; set; }
        public static int YetkiID { get; set; }
        public static int KullaniciID { get; set; }
    }
}
