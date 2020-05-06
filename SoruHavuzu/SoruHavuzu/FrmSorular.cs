using Business;
using DataManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Model.Values;

namespace SoruHavuzu
{
    public partial class FrmSorular : Form
    {
    
        int oturumid;
        DateTime sure1;
        public FrmSorular(int id,DateTime sure)
        {
            InitializeComponent();
            oturumid = id;
            sure1 = sure;

        }
        int SoruSira = 1;
        public DataTable dt; //Tabloyu üzerine olduğu gibi alan tablo değişkeni
        int sorusayisi; //En son sorunun sayısını tutat,sırasını. En son eklene soru 20 ise 20 yi tutar
        int SoruID;
        byte soruturu; //Soru türüm boşluk mu yoksa şıklı bunu kontrol etmek için vardır.
        //int SCevapID;
        string dogruCevap;
        //string SCevap;
        //int CevapID;
        int puan; //Veritabanındaki puan sütununu tutan değişken.
        int toplamPuan = 0; //Öğrencinin aldığı toplam puan
        string boslukcevap;

        
     
        void SoruGetir()
        {
           
           if (SoruSira <= sorusayisi)
            {
                
                dt = DataSqlQuestion.GetSoruGetir(oturumid, SoruSira);
                //Random rastgele = new Random();
                //SoruSira = rastgele.Next();

                if (dt.Rows.Count > 0)
                {
                    SoruID = dt.Rows[0]["SoruID"].ToInt32();

                    txtSoru.Text = dt.Rows[0]["SoruAdi"].ToString();
                    puan = dt.Rows[0]["Puan"].ToInt32();

                    if (dt.Rows[0]["SoruTuru"].ToBoolean())
                    {
                        soruturu = 1;
                        //bosluk 
                        grupSecenekler.Visible = false;
                        lblUyarı.Visible = true;
                        dt = DataSqlQuestion.GetBoslukGetir(SoruID);
                        txtBosluk.Visible = true;
                        //txtBosluk.Text = dt.Rows[0]["Bosluk"].ToString();
                        dogruCevap = txtBosluk.Text;
                        
                        
                    }
                    else
                    {
                        soruturu = 0;
                        grupSecenekler.Visible = true;
                        lblUyarı.Visible = false;
                        dt = DataSqlQuestion.GetSecenekGetir(SoruID);
                        txtA.Text = dt.Rows[0]["A"].ToString();
                        txtB.Text = dt.Rows[0]["B"].ToString();
                        txtC.Text = dt.Rows[0]["C"].ToString();
                        txtD.Text = dt.Rows[0]["D"].ToString();
                        txtE.Text = dt.Rows[0]["E"].ToString();

                    }
                    lblSoruSirasi.Text = SoruSira.ToString();

                }
               
                else
                {
                    MessageBox.Show("Test Bitti");
                    SoruSira = 1;
                }
                
            }

           if (SoruSira > sorusayisi)
            {
                grupSecenekler.Visible = false;
                txtBosluk.Visible = false;
                txtSoru.Visible = false;
                lblUyarı.Visible = false;
                MessageBox.Show("Puanınız"+toplamPuan);


            }
        }

        private void FrmSorular_Load(object sender, EventArgs e)
        {

            dt = DataSqlQuestion.SoruSayi(oturumid);
            sorusayisi = (dt.Rows[0]["SoruSirasi"].ToInt32());
            //Random rastgele = new Random();
            //SoruSira = rastgele.Next();
            SoruGetir();


        }

        //Kullanıcıdan girilen cevapların veritabanı ile karşılaştırılması
        void cevapgonder()
        { 
            
           
            if (soruturu==1)
            {
                dogruCevap = txtBosluk.Text;
                dt=DataSqlQuestion.BoslukDogruCevabiGonder(SoruID, dogruCevap);
                if (dt.Rows.Count > 0)
                {
                    dogruCevap = dt.Rows[0]["BCevap"].ToString();
                    //sonuc();
                    MessageBox.Show("DOĞRU");
                    toplamPuan = toplamPuan + puan;


                }
                


            }
            else  
            {
                


                if (radioA.Checked==true)
                {
                    dogruCevap = txtA.Text;
                   dt= DataSqlQuestion.DogruCevabiGonder(SoruID, dogruCevap);
                    if (dt.Rows.Count > 0)
                    {
                        dogruCevap= dt.Rows[0]["Cevap"].ToString();
                        toplamPuan = toplamPuan + puan;
                        MessageBox.Show("A DOĞRU");


                    }
                    else
                        MessageBox.Show("Yanlışşş");


                    //dt = DataSqlQuestion.SecenekliDogruCevabiGonder(SoruID, dogruCevap);
                    //dogruCevap = (dt.Rows[0]["Cevap"].ToString());

                    //dogruCevap = txtA.Text;
                    //DataSqlQuestion.SecenekliDogruCevabiGonder(SoruID, dogruCevap);
                    //if (dogruCevap == txtA.Text)
                    //    MessageBox.Show("A DOĞRU");
                    //else
                    //    MessageBox.Show("Yanlıi");

                    //dogruCevap = txtA.Text;

                    //MessageBox.Show("A DOĞRU");




                }
                else if (radioB.Checked==true)
                {
                    dogruCevap = txtB.Text;
                    dt = DataSqlQuestion.DogruCevabiGonder(SoruID, dogruCevap);
                    if (dt.Rows.Count > 0)
                    {
                        string dogrucevap = dt.Rows[0]["Cevap"].ToString();
                        //sonuc();
                        toplamPuan = toplamPuan + puan;
                        MessageBox.Show("B DOĞRU");


                    }
                    else
                        MessageBox.Show("Yanlışşş");

                }
                else if (radioC.Checked==true)
                {
                    dogruCevap = txtC.Text;

                    dt = DataSqlQuestion.DogruCevabiGonder(SoruID, dogruCevap);
                    if (dt.Rows.Count > 0)
                    {
                        dogruCevap = dt.Rows[0]["Cevap"].ToString();
                        //sonuc();
                        toplamPuan = toplamPuan + puan;
                        MessageBox.Show("C DOĞRU");


                    }
                    else
                        MessageBox.Show("Yanlışşş");

                }
                else if (radioD.Checked==true)
                {
                    dogruCevap = txtD.Text;
                    dt = DataSqlQuestion.DogruCevabiGonder(SoruID, dogruCevap);
                    if (dt.Rows.Count > 0)
                    {
                        string dogrucevap = dt.Rows[0]["Cevap"].ToString();
                        //sonuc();
                        toplamPuan = toplamPuan + puan;
                        MessageBox.Show("D DOĞRU");


                    }
                    else
                        MessageBox.Show("Yanlışşş");
                }
                else if (radioE.Checked==true)
                {
                    dogruCevap = txtE.Text;
                    dt = DataSqlQuestion.DogruCevabiGonder(SoruID, dogruCevap);
                    if (dt.Rows.Count > 0)
                    {
                        string dogrucevap = dt.Rows[0]["Cevap"].ToString();
                        //sonuc();
                        toplamPuan = toplamPuan + puan;
                        MessageBox.Show("E DOĞRU");


                    }
                    else
                        MessageBox.Show("Yanlışşş");
                }

            }
           
        }
        /*
        void sonuc()
        {

            toplamPuan = toplamPuan + puan;

        }
        */
        private void btnIleri_Click(object sender, EventArgs e)
        {

            //if (SoruSira!=1)
            cevapgonder();
            SoruSira++;
            lblTopPuan.Text = toplamPuan.ToString();
            SoruGetir();
            txtBosluk.Text = "";

            



        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            
            {
                DialogResult cikis = new DialogResult();
                cikis = MessageBox.Show("Çıkış Yapmak İstiyor Musunuz?", "Uyarı", MessageBoxButtons.YesNo);
                if (cikis == DialogResult.Yes)
                {
                    FrmGiris Anasayfa = new FrmGiris();
                    Anasayfa.Show();
                    this.Hide();
                }
                DataSqlQuestion.NotlariEkle(oturumid, Sessions.KullaniciID, toplamPuan);
            }



        }
    }
}

