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
    public partial class FrmYonetici : Form
    {
        public FrmYonetici()
        {
            InitializeComponent();
        }

        private void btnOgrt_Click(object sender, EventArgs e)
        {
            var frm = new FrmOgretmenEkle() { MdiParent = Application.OpenForms["FrmYonetici"] as FrmYonetici};
            frm.Show();
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            var frm = new FrmOgrenci() { MdiParent = Application.OpenForms["FrmYonetici"] as FrmYonetici };
            frm.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            FrmGiris Anasayfa = new FrmGiris();
            Anasayfa.Show();
            this.Hide();
        }
    }
}
