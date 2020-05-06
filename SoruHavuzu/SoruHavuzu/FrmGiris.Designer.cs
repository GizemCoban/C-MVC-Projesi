namespace SoruHavuzu
{
    partial class FrmGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiris));
            this.BtnYonetici = new DevExpress.XtraEditors.SimpleButton();
            this.BtnOgretmen = new DevExpress.XtraEditors.SimpleButton();
            this.BtnOgrenci = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnYonetici
            // 
            this.BtnYonetici.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnYonetici.Appearance.Options.UseFont = true;
            this.BtnYonetici.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.BtnYonetici.Image = ((System.Drawing.Image)(resources.GetObject("BtnYonetici.Image")));
            this.BtnYonetici.Location = new System.Drawing.Point(56, 144);
            this.BtnYonetici.Name = "BtnYonetici";
            this.BtnYonetici.Size = new System.Drawing.Size(234, 43);
            this.BtnYonetici.TabIndex = 0;
            this.BtnYonetici.Text = "YÖNETİCİ GİRİŞ";
            this.BtnYonetici.Click += new System.EventHandler(this.BtnYonetici_Click);
            // 
            // BtnOgretmen
            // 
            this.BtnOgretmen.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOgretmen.Appearance.Options.UseFont = true;
            this.BtnOgretmen.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.BtnOgretmen.Image = ((System.Drawing.Image)(resources.GetObject("BtnOgretmen.Image")));
            this.BtnOgretmen.Location = new System.Drawing.Point(56, 193);
            this.BtnOgretmen.Name = "BtnOgretmen";
            this.BtnOgretmen.Size = new System.Drawing.Size(234, 43);
            this.BtnOgretmen.TabIndex = 1;
            this.BtnOgretmen.Text = "ÖĞRETMEN GİRİŞ";
            this.BtnOgretmen.Click += new System.EventHandler(this.BtnOgretmen_Click);
            // 
            // BtnOgrenci
            // 
            this.BtnOgrenci.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOgrenci.Appearance.Options.UseFont = true;
            this.BtnOgrenci.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.BtnOgrenci.Image = ((System.Drawing.Image)(resources.GetObject("BtnOgrenci.Image")));
            this.BtnOgrenci.Location = new System.Drawing.Point(56, 242);
            this.BtnOgrenci.Name = "BtnOgrenci";
            this.BtnOgrenci.Size = new System.Drawing.Size(234, 43);
            this.BtnOgrenci.TabIndex = 2;
            this.BtnOgrenci.Text = "ÖĞRENCİ GİRİŞ";
            this.BtnOgrenci.Click += new System.EventHandler(this.BtnOgrenci_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::SoruHavuzu.Properties.Resources.logo4;
            this.panel1.Controls.Add(this.BtnYonetici);
            this.panel1.Controls.Add(this.BtnOgrenci);
            this.panel1.Controls.Add(this.BtnOgretmen);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 355);
            this.panel1.TabIndex = 3;
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 355);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GİRİŞ";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BtnYonetici;
        private DevExpress.XtraEditors.SimpleButton BtnOgretmen;
        private DevExpress.XtraEditors.SimpleButton BtnOgrenci;
        private System.Windows.Forms.Panel panel1;
    }
}