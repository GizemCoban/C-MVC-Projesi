namespace SoruHavuzu
{
    partial class FrmGirisYetki
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGirisYetki));
            this.BtnGiris = new DevExpress.XtraEditors.SimpleButton();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAnasayfayaDon = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnGiris
            // 
            this.BtnGiris.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGiris.Appearance.Options.UseFont = true;
            this.BtnGiris.Image = ((System.Drawing.Image)(resources.GetObject("BtnGiris.Image")));
            this.BtnGiris.Location = new System.Drawing.Point(184, 249);
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.Size = new System.Drawing.Size(100, 35);
            this.BtnGiris.TabIndex = 0;
            this.BtnGiris.Text = "GİRİŞ";
            this.BtnGiris.Click += new System.EventHandler(this.BtnGiris_Click);
            // 
            // txtAdi
            // 
            this.txtAdi.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdi.Location = new System.Drawing.Point(91, 159);
            this.txtAdi.Multiline = true;
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(193, 28);
            this.txtAdi.TabIndex = 1;
            this.txtAdi.Click += new System.EventHandler(this.txtAdi_Click);
            this.txtAdi.TextChanged += new System.EventHandler(this.txtAdi_TextChanged);
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(92, 197);
            this.txtSifre.Multiline = true;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(193, 28);
            this.txtSifre.TabIndex = 2;
            this.txtSifre.Click += new System.EventHandler(this.txtSifre_Click);
            this.txtSifre.TextChanged += new System.EventHandler(this.txtSifre_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::SoruHavuzu.Properties.Resources.logo4;
            this.panel1.Controls.Add(this.btnAnasayfayaDon);
            this.panel1.Controls.Add(this.txtAdi);
            this.panel1.Controls.Add(this.BtnGiris);
            this.panel1.Controls.Add(this.txtSifre);
            this.panel1.Location = new System.Drawing.Point(2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 355);
            this.panel1.TabIndex = 5;
            // 
            // btnAnasayfayaDon
            // 
            this.btnAnasayfayaDon.Image = ((System.Drawing.Image)(resources.GetObject("btnAnasayfayaDon.Image")));
            this.btnAnasayfayaDon.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnAnasayfayaDon.Location = new System.Drawing.Point(76, 249);
            this.btnAnasayfayaDon.Name = "btnAnasayfayaDon";
            this.btnAnasayfayaDon.Size = new System.Drawing.Size(81, 35);
            this.btnAnasayfayaDon.TabIndex = 3;
            this.btnAnasayfayaDon.Click += new System.EventHandler(this.btnAnasayfayaDon_Click);
            // 
            // FrmGirisYetki
            // 
            this.AcceptButton = this.BtnGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 334);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGirisYetki";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GİRİŞ";
            this.Load += new System.EventHandler(this.FrmGirisYetki_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BtnGiris;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnAnasayfayaDon;
        private System.Windows.Forms.TextBox txtSifre;
    }
}