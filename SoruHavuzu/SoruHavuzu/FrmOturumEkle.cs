using Business;
using DataManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoruHavuzu
{
    public partial class FrmOturumEkle : Form
    {
        public FrmOturumEkle()
        {
            InitializeComponent();
            dateBaslangic.EditValue = DateTime.Now.ToShortDateString();
            dateBitis.EditValue = DateTime.Now.ToShortDateString();
        }
     
       
        private void btnOlustur_Click(object sender, EventArgs e)
        {
            if (txtOtrAdi.Text == "" || txtOtrSifre.Text == "")
            { MessageBox.Show("Boş Bıraktığınız Alanları Doldurunuz"); }
            else if (dateBaslangic.ToDateTime() > dateBitis.ToDateTime())
            {
                MessageBox.Show("Tarih alanlarını kontrol ediniz");
            }
            else
            {
                /* string Start = Convert.ToDateTime(dateEdit1.EditValue).ToString("yyyy-MM-dd");
                    string Finish = Convert.ToDateTime(dateEdit2.EditValue).ToString("yyyy-MM-dd") + " " + "23:59:59";*/
                Model.Values.Oturum otr = new Model.Values.Oturum()
                {

                    OturumAdi = txtOtrAdi.Text,
                    OturumSifre = txtOtrSifre.Text,
                    OturumBaslangicTarihi = Convert.ToDateTime(dateBaslangic.EditValue).ToString("yyyy-MM-dd"),
                    OturumBitisTarihi = Convert.ToDateTime(dateBitis.EditValue).ToString("yyyy-MM-dd") + " " + "23:59:59",
                    OturumSuresi=Convert.ToDateTime(timeOturum.EditValue).ToString("HH:mm:ss"),

                };
                try
                {
                    DataSqlQuestion.SetOturumEkle(otr);
                    MessageBox.Show("Kayıt Başarılı");
                    txtOtrAdi.Text = "";
                    txtOtrSifre.Text = "";
                    dateBaslangic.EditValue = DateTime.Now.ToShortDateString();
                    dateBitis.EditValue = DateTime.Now.ToShortDateString();
                    timeOturum.EditValue ="00:00:00";
                }
                catch(Exception ex)
                {
                    MessageBox.Show(" "+ex);
                }
            }

        }
    }
}
