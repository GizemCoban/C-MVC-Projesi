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
    public partial class FrmOgrenci : Form
    {
        public FrmOgrenci()
        {
            InitializeComponent();
        }

        public string OAdi = "";
        public string Sifre = "";
        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            if (txtOgrenciKullanici.Text == "" || txtOgrenciSifre.Text == "")
            {
                MessageBox.Show("Boş bıraktığınız alanları doldurunuz");

            }
            else
            {



                Model.Values.Ogrenci ogrc = new Model.Values.Ogrenci()
                {
                    OgrenciAdi = txtOgrenciKullanici.Text,
                    OgrenciSoyadi = txtSoyadi.Text,
                    Sifre = txtOgrenciSifre.Text,
                    

                };
                DataSqlQuestion.OgrenciEkle(ogrc);
                MessageBox.Show("Kayıt Başarılı");
                txtOgrenciKullanici.Text = "";
                txtSoyadi.Text = "";
                txtOgrenciSifre.Text = "";

            }
        }
    }
}
