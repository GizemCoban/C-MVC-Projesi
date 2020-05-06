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
using DevExpress.XtraEditors;


namespace SoruHavuzu
{
    public partial class FrmNotlariGor : Form

    {
        int oturumid;

        public FrmNotlariGor(int id)
        {
           
            InitializeComponent();
            oturumid = id;
        }
        void Refresh()
        {
            gridControl1.DataSource = DataSqlQuestion.GetExcellListesi(oturumid);

        }

        private void exelGor_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK) //Excele Aktar düğmesinde basılırsa.
            {

                gridView1.ExportToXlsx(save.FileName + ".xlsx"); //2007+ Office'ler için.
            }
        }

        private void FrmNotlariGor_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //SaveFileDialog save = new SaveFileDialog();
            //if (save.ShowDialog() == DialogResult.OK) //Excele Aktar düğmesinde basılırsa.
            //{

            //    gridView1.ExportToXlsx(save.FileName + ".xlsx"); //2007+ Office'ler için.
            //}

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = ".xls (*.xls)|*.xls";
            sfd.FileName = ".xls";
            DialogResult res = sfd.ShowDialog();
            if (res == DialogResult.OK)
            {
                gridView1.ExportToXls(sfd.FileName);
            }


        }
    }
}

