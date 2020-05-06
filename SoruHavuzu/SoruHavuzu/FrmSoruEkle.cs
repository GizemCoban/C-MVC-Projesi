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
    public partial class FrmSoruEkle : Form
    {
        public int Oturum;
        public FrmSoruEkle(int OturumID)
        {
            InitializeComponent();
            Oturum = OturumID;
        }
        int SoruSıra;
        public DataTable dt;
        int SoruID;
        int cont = 0;
        bool secenek;
        public int guncelle = 0;
        void Refresh()
        {
            dt = DataSqlQuestion.SoruSayi(Oturum);

            if (dt.Rows.Count > 0)
            {
                txtSıra.Text = (dt.Rows[0]["SoruSirasi"].ToInt32() + 1).ToString();
                SoruSıra = txtSıra.Text.ToInt32();

            }
            else
            { SoruSıra = 1;

                txtSıra.Text = SoruSıra.ToString();            }
            dt = DataSqlQuestion.ToplamPuan(Oturum);
            lblPuan.Text = dt.Rows[0]["Puan"].ToString();

        }
        private void FrmSoruEkle_Load(object sender, EventArgs e)
        {
            Refresh();
            //labelControl1.Visible = false;

        }

        //Buton olayına hangi radio buton seçili ise 
     
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
            if (radioSecenek.Checked == true)
            {
                radioBosluk.Checked = false;
                if (txtA.Text == " " || txtB.Text == " " || txtC.Text == " " || txtD.Text == " " || txtE.Text == " ")
                {
                    MessageBox.Show("Boş bıraktığınız seçenekler var");
                }
                else if (txtPuan.Text == "")
                {
                    MessageBox.Show("Puan alanını doldurunuz");
                }
                else
                {
                    Model.Values.Soru Soru = new Model.Values.Soru
                    {
                        SoruAdi = txtSoru.Text,
                        Puan = txtPuan.Text.ToInt32(),
                        SoruSirasi = txtSıra.Text.ToInt32(),
                        SecenekA = txtA.Text,
                        SecenekB = txtB.Text,
                        SecenekC = txtC.Text,
                        SecenekD = txtD.Text,
                        SecenekE = txtE.Text,
                        SoruTuru=false,
                        //SoruID = 1,
                    };
                 
                    /*SELECT * FROM tblSoru ORDER BY SoruID DESC LIMIT 1*/
                    if (guncelle == 0)
                    {
                        DataSqlQuestion.SetSoruEkle(Soru, Oturum);
                        btnKaydet.Text = "KAYDET";
                        dt = DataSqlQuestion.SetSoruID(Oturum);

                        SoruID = dt.Rows[0]["SoruID"].ToInt32();
                        DataSqlQuestion.SetSecenekEkle(Soru, SoruID);
                        if (radioA.Checked)
                        {
                            secenek = true;
                            DataSqlQuestion.SetDogru(txtA.Text, SoruID);
                        }
                        else if (radioB.Checked)
                        {
                            secenek = true;
                            DataSqlQuestion.SetDogru(txtB.Text, SoruID);
                        }
                        else if (radioC.Checked)
                        {
                            secenek = true;
                            DataSqlQuestion.SetDogru(txtC.Text, SoruID);

                        }
                        else if (radioD.Checked)
                        {
                            secenek = true;
                            DataSqlQuestion.SetDogru(txtD.Text, SoruID);
                        }
                        else if (radioE.Checked)
                        {
                            secenek = true;
                            DataSqlQuestion.SetDogru(txtE.Text, SoruID);
                        }
                        if (secenek == false)
                        {
                            MessageBox.Show("Doğru cevabı seçiniz.");

                        }
                        else
                        {
                            txtA.Text = "";
                            txtB.Text = "";
                            txtC.Text = "";
                            txtD.Text = "";
                            txtE.Text = "";
                            txtSoru.Text = "";
                            txtPuan.Text = "";
                            txtSıra.Text = (dt.Rows[0]["SoruSirasi"].ToInt32() + 1).ToString();
                        }
                    }
                    else
                    {
                        DataSqlQuestion.SetSoruGuncelle(SoruID,Soru);
                 
                        txtA.Text = "";
                        txtB.Text = "";
                        txtC.Text = "";
                        txtD.Text = "";
                        txtE.Text = "";
                        txtSoru.Text = "";
                        grupSecenekler.Visible = false;
                        radioBosluk.Checked = false;
                        radioSecenek.Checked = false;
                        txtPuan.Text = "";
                        txtSıra.Text = (dt.Rows[0]["SoruSirasi"].ToInt32() + 1).ToString();


                    }
                 
                }


            }
            else if (radioBosluk.Checked == true)
            {
                radioSecenek.Checked = false;
                if (txtBosluk.Text == " ")
                {
                    MessageBox.Show("Boş bıraktığınız alanı doldurunuz.");

                }
                else if (txtPuan.Text == "")
                {
                    MessageBox.Show("Puan alanını doldurunuz");
                }
                else
                {
                    Model.Values.Soru Soru = new Model.Values.Soru
                    {

                        SoruAdi = txtSoru.Text,
                        Puan = txtPuan.Text.ToInt32(),
                        SoruSirasi = txtSıra.Text.ToInt32(),
                        Bosluk = txtBosluk.Text,
                        SoruTuru = true,

                        //SoruID = 1,
                    };
                    if (guncelle == 0)
                    {
                        DataSqlQuestion.SetSoruEkle(Soru, Oturum);
                        btnKaydet.Text = "KAYDET";
                        dt = DataSqlQuestion.SetSoruID(Oturum);

                        SoruID = dt.Rows[0]["SoruID"].ToInt32();
                        DataSqlQuestion.SetBoslukEkle(txtBosluk.Text, SoruID);
                        //txtBosluk.Text = "";
                        txtPuan.Text = "";
                        txtSıra.Text = (dt.Rows[0]["SoruSirasi"].ToInt32() + 1).ToString();
                        if (txtBosluk.Text != "")
                        {
                            DataSqlQuestion.SetDogru(txtBosluk.Text, SoruID);
                            txtBosluk.Text = "";
                            txtSoru.Text = "";
                            grupSecenekler.Visible = false;
                            radioBosluk.Checked = false;
                            radioSecenek.Checked = false;
                            txtPuan.Text = "";
                            txtSıra.Text = (dt.Rows[0]["SoruSirasi"].ToInt32() + 1).ToString();
                        }
                    }
                }
                
                
                
                
            }
            else {
                MessageBox.Show("Bir seçenek seçiniz");
            }
            Refresh();
        }

        private void radioSecenek_CheckedChanged(object sender, EventArgs e)
        {
            grupSecenekler.Visible = true;
            labelControl1.Visible = false;
            txtBosluk.Visible = false;
            lblUyarı.Visible = false;
            txtSıra.Text = SoruSıra.ToString();
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            txtD.Text = "";
            txtE.Text = "";
            txtPuan.Text = "";
        }
        
        private void btnSoruyaGit_Click(object sender, EventArgs e)
        {
            int sorusirasi = txtSıra.Text.ToInt32();

            btnKaydet.Text = "GÜNCELLE";
            guncelle = 1;
            //dt = DataSqlQuestion.GetSoruGetir(Oturum, sorusirasi);
            //txtSıra.Text = sorusirasi.ToString();
            if (dt.Rows.Count > 0)
            {
                SoruID = dt.Rows[0]["SoruID"].ToInt32();
                txtSoru.Text = dt.Rows[0]["SoruAdi"].ToString();
                txtPuan.Text = dt.Rows[0]["Puan"].ToString();
                if (dt.Rows[0]["SoruTuru"].ToBoolean())
                {

                    //bosluk

                    grupSecenekler.Visible = false;
                    radioSecenek.Checked = false;
                    radioBosluk.Checked = false;
                    txtSıra.Text = sorusirasi.ToString();
                    dt = DataSqlQuestion.GetSecenekGetir(SoruID);
                    txtB.Text = dt.Rows[0]["Bosluk"].ToString();
                }
                else
                {
                    grupSecenekler.Visible = true;
                    radioSecenek.Checked = true;
                    radioBosluk.Checked = false;
                    txtSıra.Text = sorusirasi.ToString();
                    dt = DataSqlQuestion.GetSecenekGetir(SoruID);
                    txtA.Text = dt.Rows[0]["A"].ToString();
                    txtB.Text = dt.Rows[0]["B"].ToString();
                    txtC.Text = dt.Rows[0]["C"].ToString();
                    txtD.Text = dt.Rows[0]["D"].ToString();
                    txtE.Text = dt.Rows[0]["E"].ToString();

                }
            }
            else
            { MessageBox.Show("Böyle bir soru yoktur"); }
            /*  txtA.Text = "";
              txtB.Text = dt.Rows[0]["SoruSirasi"].ToString()"";
              txtC.Text = "";
              txtD.Text = "";
              txtE.Text = "";
              txtPuan.Text = "";*/


        }

        private void radioBosluk_CheckedChanged(object sender, EventArgs e)
        {
            grupSecenekler.Visible = false;
            lblUyarı.Visible = true;
            txtBosluk.Visible = true;
            txtBosluk.Text = "";
            txtSıra.Text = SoruSıra.ToString();
            txtPuan.Text = "";



        }
    }
}
