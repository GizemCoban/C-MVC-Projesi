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
    public partial class FrmGirisYetki : Form
    {
        public int b; //YetkiID
        public string kAdi = "", Sifre = "";
        DataTable dt;
        public FrmGirisYetki(int a)
        {
            //a yetki cesidi
            InitializeComponent();
            b = a;
        }
        //Giriş sayfasına tekrar dönmek için
        private void btnAnasayfayaDon_Click(object sender, EventArgs e)
        {
            FrmGiris Anasayfa = new FrmGiris();
            Anasayfa.Show();
            this.Hide();

        }
       void Refresh()
        {
            txtSifre.PasswordChar = '*';

        }

        private void FrmGirisYetki_Load(object sender, EventArgs e)
        {
            txtAdi.Text = "Kullanıcı Adı";
            txtSifre.Text = "Şifre";
                

        }

        private void txtAdi_TextChanged(object sender, EventArgs e)
        {
            //txtAdi.Text = "";
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            //txtSifre.Text = "";
            //txtSifre.PasswordChar = '*';
        }

        private void txtAdi_Click(object sender, EventArgs e)
        {
            txtAdi.Text = " ";

        }

        private void txtSifre_Click(object sender, EventArgs e)
        {
            
            txtSifre.Text = " ";
            txtSifre.PasswordChar = '*';
            //Refresh();



        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            


            if (txtAdi.Text == "" || txtSifre.Text == "")
            {
                MessageBox.Show("Bu alanları boş geçmeyiniz.");
            }

            
            else {


                    if (b == 1)
                    {
                        Sessions.YetkiID = 1;
                        kAdi = txtAdi.Text;
                        Sifre = txtSifre.Text;

                        dt = DataSqlQuestion.GetYoneticiKontrol(kAdi, Sifre);
                        if (dt.Rows.Count > 0)
                        {
                            Sessions.KullaniciID = dt.Rows[0]["YoneticiID"].ToInt32();
                            FrmYonetici Frm = new FrmYonetici();
                            Frm.Show();
                            this.Hide();
                        }
                        else 
                        {
                            MessageBox.Show("Kullanıcı Bulunamadı");

                        }

                    }
                    else if (b == 2)
                    {
                        Sessions.YetkiID = 2;
                        //dt = DataSqlQuestion.GetYetki(b);

                        kAdi = txtAdi.Text;
                        Sifre = txtSifre.Text;

                        dt = DataSqlQuestion.GetOgretmenKontrol(kAdi, Sifre);

                        if (dt.Rows.Count > 0)
                        {
                            Sessions.KullaniciID = dt.Rows[0]["OgretmenID"].ToInt32();
                            FrmOgretmenEkran Frm = new FrmOgretmenEkran();
                            Frm.Show();
                            this.Hide();

                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı Bulunamadı");

                        }

                    }
                    else
                    {

                        Sessions.YetkiID = 3;
                        //dt = DataSqlQuestion.GetYetki(b);

                        kAdi = txtAdi.Text;
                        Sifre = txtSifre.Text;

                        dt = DataSqlQuestion.GetOgrenciKontrol(kAdi, Sifre);
                        if (dt.Rows.Count > 0)
                        {
                            Sessions.KullaniciID = dt.Rows[0]["OgrenciID"].ToInt32();
                            FrmOgrenciGiris Frm = new FrmOgrenciGiris();
                            Frm.Show();
                            this.Hide();

                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı Bulunamadı");
                        }

                    }
                
            }
        }
    }
}
