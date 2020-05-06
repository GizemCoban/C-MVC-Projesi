using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoruHavuzu
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Sessions.ConnectionStringSql = @"Data Source=DESKTOP-OUE9KUT; Initial Catalog=soruhavuzu;User ID=gizem;Password=coban";
            
            Application.Run(new FrmGiris());
        }
    }
}
