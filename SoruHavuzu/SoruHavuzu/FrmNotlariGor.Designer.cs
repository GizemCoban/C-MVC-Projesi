namespace SoruHavuzu
{
    partial class FrmNotlariGor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.KullaniciAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KullaniciSoyadi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ToplamPuan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SonucID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Oturum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.OgrenciID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControl1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(951, 383);
            this.panel1.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 100);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(951, 283);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.KullaniciAdi,
            this.KullaniciSoyadi,
            this.ToplamPuan,
            this.SonucID,
            this.gridColumn1,
            this.Oturum});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // KullaniciAdi
            // 
            this.KullaniciAdi.Caption = "Adı";
            this.KullaniciAdi.FieldName = "KullaniciAdi";
            this.KullaniciAdi.Name = "KullaniciAdi";
            this.KullaniciAdi.Visible = true;
            this.KullaniciAdi.VisibleIndex = 1;
            // 
            // KullaniciSoyadi
            // 
            this.KullaniciSoyadi.Caption = "Soyadı";
            this.KullaniciSoyadi.FieldName = "KullaniciSoyadi";
            this.KullaniciSoyadi.Name = "KullaniciSoyadi";
            this.KullaniciSoyadi.Visible = true;
            this.KullaniciSoyadi.VisibleIndex = 2;
            // 
            // ToplamPuan
            // 
            this.ToplamPuan.Caption = "Puan";
            this.ToplamPuan.FieldName = "ToplamPuan";
            this.ToplamPuan.Name = "ToplamPuan";
            this.ToplamPuan.Visible = true;
            this.ToplamPuan.VisibleIndex = 3;
            // 
            // SonucID
            // 
            this.SonucID.Caption = "SonucID";
            this.SonucID.FieldName = "SonucID";
            this.SonucID.Name = "SonucID";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Öğrenci No";
            this.gridColumn1.FieldName = "OgrenciID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // Oturum
            // 
            this.Oturum.Caption = "OturumID";
            this.Oturum.FieldName = "OturumID";
            this.Oturum.Name = "Oturum";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.simpleButton1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(951, 100);
            this.panel2.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.simpleButton1.Appearance.BackColor2 = System.Drawing.Color.Yellow;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.simpleButton1.Image = global::SoruHavuzu.Properties.Resources.Microsoft_Excel_icon;
            this.simpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButton1.Location = new System.Drawing.Point(31, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(117, 82);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Excelle Kaydet";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // OgrenciID
            // 
            this.OgrenciID.Caption = "Öğrenci No";
            this.OgrenciID.FieldName = "OgrenciID";
            this.OgrenciID.Name = "OgrenciID";
            this.OgrenciID.Visible = true;
            this.OgrenciID.VisibleIndex = 0;
            // 
            // FrmNotlariGor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(951, 383);
            this.Controls.Add(this.panel1);
            this.Name = "FrmNotlariGor";
            this.Text = "FrmNotlariGor";
            this.Load += new System.EventHandler(this.FrmNotlariGor_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn KullaniciAdi;
        private DevExpress.XtraGrid.Columns.GridColumn KullaniciSoyadi;
        private DevExpress.XtraGrid.Columns.GridColumn ToplamPuan;
        private DevExpress.XtraGrid.Columns.GridColumn SonucID;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.Columns.GridColumn OgrenciID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn Oturum;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}