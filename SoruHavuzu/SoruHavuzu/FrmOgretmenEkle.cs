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
    public partial class FrmOgretmenEkle : Form
    {
        public FrmOgretmenEkle()
        {
            InitializeComponent();
        }

        public string OAdi="";
        public string Sifre="";

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "" || txtSifre.Text == "")
            {
                MessageBox.Show("Boş bıraktığınız alanları doldurunuz");

            }
            else
            {
                /*
                     Model.Elif.Urun urun = new Model.Elif.Urun()
                {
                    Barcode = txtBarcode.Text,
                    BirimFiyati = txtFiyat.Text.ToDouble(),
                    BirimID = cmbBirim.SelectedValue.ToInt32(),
                    Doviz = cmbDoviz.Text,
                    Fiyat = txtFiyat.Text.ToDouble(),
                    KDVFiyat = KDVFiyat.Text.ToDouble(),
                    KDVID = cmbKDV.SelectedValue.ToInt32(),
                    Miktar = txtMiktar.Text.ToDouble(),
                    UrunAdi = txtUrunAd.Text,
                    tutar = tutar.ToDouble(),


                };
                DataAcces.UrunAdd(urun);
             */

                Model.Values.Ogretmen ogrt = new Model.Values.Ogretmen()
                {
                    OgretmenAdi = txtKullaniciAdi.Text,
                    OgretmenSoyadi = txtSoyadi.Text,
                    Sifre=txtSifre.Text,
               
                };
                DataSqlQuestion.OgretmenEkle(ogrt);
                MessageBox.Show("Kayıt Başarılı");
                txtKullaniciAdi.Text = "";
                txtSoyadi.Text = "";
                txtSifre.Text = "";
              

            }
        }
    }
}
