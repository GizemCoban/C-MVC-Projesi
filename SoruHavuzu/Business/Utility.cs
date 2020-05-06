using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public static class Utility
    {
        public static bool IsInternet()
        {
            try
            {
                System.Net.Sockets.TcpClient client = new System.Net.Sockets.TcpClient("www.google.com", 80);
                client.Close();
                return true;
            }
            catch
            {
                //  MyMessageBox.MyMboxInternet();
                return false;
            }
        }


     
    

       

        public static string ToURL(this string s)
        {
            if (string.IsNullOrEmpty(s)) return "";
            if (s.Length > 80)
                s = s.Substring(0, 80);
            s = s.Replace("ş", "s");
            s = s.Replace("Ş", "S");
            s = s.Replace("ğ", "g");
            s = s.Replace("Ğ", "G");
            s = s.Replace("İ", "I");
            s = s.Replace("ı", "i");
            s = s.Replace("ç", "c");
            s = s.Replace("Ç", "C");
            s = s.Replace("ö", "o");
            s = s.Replace("Ö", "O");
            s = s.Replace("ü", "u");
            s = s.Replace("Ü", "U");
            s = s.Replace("'", "");
            s = s.Replace("\"", "");
            
          
            if (!string.IsNullOrEmpty(s))
                while (s.IndexOf("--") > -1)
                    s = s.Replace("--", "-");
            if (s.StartsWith("-")) s = s.Substring(1);
            if (s.EndsWith("-")) s = s.Substring(0, s.Length - 1);
            return s;
        }

        //Bir stringi verilen miktarda karakterler barındıracak şekilde satırlara bölme:
        public static string ToMultiLineString(this string str, int count)
        {
            string yeni = "";
            for (int i = 0; i < str.Length; i += count)
            {
                if (i > 0)
                    yeni += "<br/>";
                if (i + count < str.Length)
                    yeni += str.Substring(i, count);
                else
                    yeni += str.Substring(i);
            }
            return yeni;
        }

        public static bool IsNullOrEmpty(this string text)
        {
            try
            {
                return String.IsNullOrEmpty(text.Trim());
            }
            catch (Exception)
            {
                return true;
            }
        }
        public static bool IsInteger(this object number)
        {
            try
            {
                if (number == DBNull.Value) return false;
                Convert.ToInt32(number);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static string GetNullOrValue(this string text)
        {
            return text.IsNullOrEmpty() ? "" : text;
        }
        public static byte ToByte(this object number)
        {
            try
            {
                if (number == DBNull.Value || number == null) return 0;
                byte x = Convert.ToByte(number);
                return x;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public static int ToInt32(this object number)
        {
            try
            {
                if (number == DBNull.Value || number == null) return 0;
                int x = Convert.ToInt32(number);
                return x;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public static long ToInt64(this object number)
        {
            try
            {
                if (number == DBNull.Value || number == null) return 0;
                long x = Convert.ToInt64(number);
                return x;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public static double ToDouble(this object number)
        {
            try
            {
                if (number == null) return 0;
                number = number.ToString().Replace('.', ',');
                double x = Convert.ToDouble(number);
                return x;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public static decimal ToDecimal(this object number)
        {
            try
            {
                if (number == DBNull.Value || number == null) return 0;
                number = number.ToString().Replace('.', ',');
                decimal x = Convert.ToDecimal(number);
                return x;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public static float ToSingle(this object number)
        {
            try
            {
                if (number == DBNull.Value || number == null) return 0;
                number = number.ToString().Replace('.', ',');
                float x = Convert.ToSingle(number);
                return x;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public static float ToSingle1(this object number)
        {
            try
            {
                if (number == DBNull.Value || number == null) return 0;
                number = number.ToString().Replace(',', '.');
                float x = Convert.ToSingle(number);
                return x;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public static string ToStringDateTime(this DateTime dateTime)
        {
            DateTime simdi = DateTime.Now;
            String s;
            if (dateTime.Hour == 0 && dateTime.Minute == 0 && dateTime.Second == 0)
            {
                if (simdi.Date == dateTime.Date)
                    s = "Bugün";
                else if (dateTime.Date.AddDays(1.0).Day == simdi.Date.Day)
                    s = "Dün";
                else
                    s = String.Format("{0:00}.{1:00}.{2}", dateTime.Day, dateTime.Month, dateTime.Year);
            }
            else
            {
                if (simdi.Date == dateTime.Date)
                    s = String.Format("Bugün {0:00}:{1:00}", dateTime.Hour, dateTime.Minute);
                else if (dateTime.Date.AddDays(1.0).Day == simdi.Date.Day)
                    s = String.Format("Dün {0:00}:{1:00}", dateTime.Hour, dateTime.Minute);
                else
                    s = String.Format("{0:00}.{1:00}.{2} {3:00}:{4:00}", dateTime.Day, dateTime.Month, dateTime.Year, dateTime.Hour, dateTime.Minute);
            }
            return s.ToString();
        }
        public static System.Data.DataSet ToDataSet(this System.Data.DataSet dataSet)
        {
            try
            {
                System.Data.DataTable dt = dataSet.Tables[0];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        string columnType = dt.Columns[j].DataType.ToString();
                        if (columnType == "System.Int32")
                        {
                            string value = dt.Rows[i][j].ToString();
                            if (value == "") dt.Rows[i][j] = 0;
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
            return dataSet;
        }
        public static string ToFormatMoney(this string money)
        {
            try
            {
                if (money == "") return "0,00";

                money = money.ToString().Replace('.', ',');
                decimal x = Convert.ToDecimal(money);
                return Math.Round(x, 2).ToString();
            }
            catch (Exception)
            {
                return "0,00";
            }
        }
        public static string ToFormatMoney(this object money)
        {
            try
            {
                if (money == null) return "0";
                if (money.ToString() == "0") return "0,00";

                string y = money.ToString().Replace('.', ',');
                decimal x = Convert.ToDecimal(y);
                return Math.Round(x, 2).ToString();
            }
            catch (Exception)
            {
                return "0,00";
            }
        }

        //Textboxlardan alınan bilgileri temizleme
        public static string ToClearText(this string s, bool endLine)
        {
            s = s.Replace("<", "&lt;");
            s = s.Replace(">", "&gt;");
            s = s.Replace("script", "scr_ipt");
            s = s.Replace("'", "`");
            s = s.Replace("\"", "`");

            if (endLine)
                s = s.Replace(Environment.NewLine, s);
            s = s.Trim();
            return s;
        }
        public static string ToClearText(this string s)
        {
            s = ToClearText(s, false);
            return s;
        }

        //Bir stringteki html satır sonlarını (<br/> <=> EOL) dosya satır sonuna çevirme:
        public const string EndLine = "<br />";

        public static string NewLineToBr(this string s)
        {
            s = s.Replace(Environment.NewLine, EndLine);
            return s;
        }
        public static string BrToNewLine(this string s)
        {
            s = s.Replace(EndLine, Environment.NewLine);
            return s;
        }

        //Bilgileri tarih be bool tiplerine dönüştürme:
        public static DateTime ToDateTime(this object s)
        {
            try
            {
                return s != DBNull.Value ? Convert.ToDateTime(s) : DateTime.Now;
            }
            catch (Exception)
            {
                return DateTime.Now;
            }
        }
        public static string ToShortDate(this object s)
        {
            try
            {
                string value = s.ToString();
             
                return value;
            }
            catch (Exception)
            {
                return "";
            }
        }
        public static TimeSpan ToTimeSpan(this object s)
        {
            try
            {
                return s != DBNull.Value ? TimeSpan.Parse(s.ToString()) : TimeSpan.Zero;
            }
            catch (Exception)
            {
                return TimeSpan.Zero;
            }
        }
        public static bool ToBoolean(this object s)
        {
            try
            {
                return (s != DBNull.Value && Convert.ToBoolean(s));
            }
            catch (Exception)
            {
                return false;
            }
        }




    }
}