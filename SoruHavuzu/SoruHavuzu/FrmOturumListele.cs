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
    public partial class FrmOturumListele : Form
    {
        public int sonucid;
        
        public FrmOturumListele()
        {
            InitializeComponent();
            
        }

        void Refresh()
        {
            gridContOturum.DataSource = DataSqlQuestion.GetOturumList();
            
        }
        

        private void FrmOturumListele_Load(object sender, EventArgs e)
        {
            Refresh();
            //gridContOturum.DataSource = DataSqlQuestion.GetExcellListesi(sonucid);
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            int id = gridViewOturum.GetFocusedRowCellValue(OturumID).ToInt32();
           // FrmSoruEkle frm = new FrmSoruEkle(id);
            var frm = new FrmSoruEkle(id) { MdiParent = Application.OpenForms["FrmOgretmenEkran"] as FrmOgretmenEkran };
            frm.Show();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = gridViewOturum.GetFocusedRowCellValue(OturumID).ToInt32();
            DataSqlQuestion.SetOturumSil(id);
            //DataSqlQuestion.SetOturumGuncelle();
            MessageBox.Show("Oturumunuz Başarıyla Silindi");
            Refresh();
            
        }

        private void btnNotGor_Click(object sender, EventArgs e)
        {
            int id = gridViewOturum.GetFocusedRowCellValue(OturumID).ToInt32();
            // DataSqlQuestion.GetExcellListesi(id);
          
            var frm = new FrmNotlariGor(id) { MdiParent = Application.OpenForms["FrmOgretmenEkran"] as FrmOgretmenEkran};
            frm.Show();
        }
    }
}
