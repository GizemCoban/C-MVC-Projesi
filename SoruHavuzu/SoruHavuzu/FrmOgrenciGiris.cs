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
    public partial class FrmOgrenciGiris : Form
    {
        public FrmOgrenciGiris()
        {
            InitializeComponent();
        }
        public DataTable dt;


        private void btnOturumGirs_Click(object sender, EventArgs e)
        {
            dt = DataSqlQuestion.OgrenciOturum(txtOturumAdi.Text); //TextBoxdan girilen oturum adı sorgudaki oturum adı ile aynı mı?
            if (dt.Rows.Count > 0)
            {
                int id = dt.Rows[0]["OturumID"].ToInt32();
                DateTime sure = dt.Rows[0]["Sure"].ToDateTime();
                FrmSorular Frm = new FrmSorular(id,sure);


                Frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Böyle Bir Oturum Bulanamadı.");

            }

        }
        
    
   
    }
}
