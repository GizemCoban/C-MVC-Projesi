namespace SoruHavuzu
{
    partial class FrmOgrenciGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrenciGiris));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtOturumAdi = new System.Windows.Forms.TextBox();
            this.btnOturumGirs = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(285, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 174);
            this.panel1.TabIndex = 0;
            // 
            // txtOturumAdi
            // 
            this.txtOturumAdi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOturumAdi.Location = new System.Drawing.Point(307, 203);
            this.txtOturumAdi.Multiline = true;
            this.txtOturumAdi.Name = "txtOturumAdi";
            this.txtOturumAdi.Size = new System.Drawing.Size(194, 35);
            this.txtOturumAdi.TabIndex = 1;
            // 
            // btnOturumGirs
            // 
            this.btnOturumGirs.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnOturumGirs.Appearance.BackColor2 = System.Drawing.Color.Yellow;
            this.btnOturumGirs.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOturumGirs.Appearance.Options.UseBackColor = true;
            this.btnOturumGirs.Appearance.Options.UseFont = true;
            this.btnOturumGirs.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnOturumGirs.Image = ((System.Drawing.Image)(resources.GetObject("btnOturumGirs.Image")));
            this.btnOturumGirs.Location = new System.Drawing.Point(307, 276);
            this.btnOturumGirs.Name = "btnOturumGirs";
            this.btnOturumGirs.Size = new System.Drawing.Size(194, 37);
            this.btnOturumGirs.TabIndex = 2;
            this.btnOturumGirs.Text = "OTURUMA GİRİŞ";
            this.btnOturumGirs.Click += new System.EventHandler(this.btnOturumGirs_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Location = new System.Drawing.Point(164, 218);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(108, 18);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "OTURUM ADI :";
            // 
            // FrmOgrenciGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(821, 410);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnOturumGirs);
            this.Controls.Add(this.txtOturumAdi);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOgrenciGiris";
            this.Text = "OTURUMA GİRİŞ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtOturumAdi;
        private DevExpress.XtraEditors.SimpleButton btnOturumGirs;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}