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
    public partial class FrmOgretmenEkran : Form
    {
        public FrmOgretmenEkran()
        {
            InitializeComponent();
        }

        private void btnOturum_Click(object sender, EventArgs e)
        {

            var frm = new FrmOturumEkle() { MdiParent = Application.OpenForms["FrmOgretmenEkran"] as FrmOgretmenEkran };
            frm.Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var frm = new FrmOturumListele() { MdiParent = Application.OpenForms["FrmOgretmenEkran"] as FrmOgretmenEkran };
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
