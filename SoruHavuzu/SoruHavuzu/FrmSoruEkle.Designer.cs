namespace SoruHavuzu
{
    partial class FrmSoruEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSoruEkle));
            this.txtSoru = new System.Windows.Forms.RichTextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.radioSecenek = new System.Windows.Forms.RadioButton();
            this.radioBosluk = new System.Windows.Forms.RadioButton();
            this.grupSecenekler = new System.Windows.Forms.GroupBox();
            this.txtE = new System.Windows.Forms.RichTextBox();
            this.txtD = new System.Windows.Forms.RichTextBox();
            this.txtC = new System.Windows.Forms.RichTextBox();
            this.txtB = new System.Windows.Forms.RichTextBox();
            this.txtA = new System.Windows.Forms.RichTextBox();
            this.radioE = new System.Windows.Forms.RadioButton();
            this.radioD = new System.Windows.Forms.RadioButton();
            this.radioC = new System.Windows.Forms.RadioButton();
            this.radioB = new System.Windows.Forms.RadioButton();
            this.radioA = new System.Windows.Forms.RadioButton();
            this.txtBosluk = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtPuan = new System.Windows.Forms.TextBox();
            this.lblUyarı = new DevExpress.XtraEditors.LabelControl();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtSıra = new System.Windows.Forms.TextBox();
            this.btnSoruyaGit = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblPuan = new DevExpress.XtraEditors.LabelControl();
            this.grupSecenekler.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSoru
            // 
            this.txtSoru.BackColor = System.Drawing.Color.Ivory;
            this.txtSoru.Location = new System.Drawing.Point(117, 36);
            this.txtSoru.Name = "txtSoru";
            this.txtSoru.Size = new System.Drawing.Size(609, 122);
            this.txtSoru.TabIndex = 0;
            this.txtSoru.Text = "";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Location = new System.Drawing.Point(74, 197);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(84, 18);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Seçenekler";
            // 
            // radioSecenek
            // 
            this.radioSecenek.AutoSize = true;
            this.radioSecenek.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioSecenek.Location = new System.Drawing.Point(156, 217);
            this.radioSecenek.Name = "radioSecenek";
            this.radioSecenek.Size = new System.Drawing.Size(88, 17);
            this.radioSecenek.TabIndex = 2;
            this.radioSecenek.TabStop = true;
            this.radioSecenek.Text = "Seçenekler";
            this.radioSecenek.UseVisualStyleBackColor = true;
            this.radioSecenek.CheckedChanged += new System.EventHandler(this.radioSecenek_CheckedChanged);
            // 
            // radioBosluk
            // 
            this.radioBosluk.AutoSize = true;
            this.radioBosluk.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioBosluk.Location = new System.Drawing.Point(370, 217);
            this.radioBosluk.Name = "radioBosluk";
            this.radioBosluk.Size = new System.Drawing.Size(120, 17);
            this.radioBosluk.TabIndex = 3;
            this.radioBosluk.TabStop = true;
            this.radioBosluk.Text = "Boşluk Doldurma";
            this.radioBosluk.UseVisualStyleBackColor = true;
            this.radioBosluk.CheckedChanged += new System.EventHandler(this.radioBosluk_CheckedChanged);
            // 
            // grupSecenekler
            // 
            this.grupSecenekler.Controls.Add(this.txtE);
            this.grupSecenekler.Controls.Add(this.txtD);
            this.grupSecenekler.Controls.Add(this.txtC);
            this.grupSecenekler.Controls.Add(this.txtB);
            this.grupSecenekler.Controls.Add(this.txtA);
            this.grupSecenekler.Controls.Add(this.radioE);
            this.grupSecenekler.Controls.Add(this.radioD);
            this.grupSecenekler.Controls.Add(this.radioC);
            this.grupSecenekler.Controls.Add(this.radioB);
            this.grupSecenekler.Controls.Add(this.radioA);
            this.grupSecenekler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grupSecenekler.Location = new System.Drawing.Point(50, 240);
            this.grupSecenekler.Name = "grupSecenekler";
            this.grupSecenekler.Size = new System.Drawing.Size(636, 363);
            this.grupSecenekler.TabIndex = 4;
            this.grupSecenekler.TabStop = false;
            this.grupSecenekler.Text = "SEÇENEKLER";
            this.grupSecenekler.Visible = false;
            // 
            // txtE
            // 
            this.txtE.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtE.Location = new System.Drawing.Point(139, 291);
            this.txtE.Name = "txtE";
            this.txtE.Size = new System.Drawing.Size(478, 53);
            this.txtE.TabIndex = 19;
            this.txtE.Text = "";
            // 
            // txtD
            // 
            this.txtD.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtD.Location = new System.Drawing.Point(139, 223);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(478, 53);
            this.txtD.TabIndex = 18;
            this.txtD.Text = "";
            // 
            // txtC
            // 
            this.txtC.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtC.Location = new System.Drawing.Point(139, 155);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(478, 53);
            this.txtC.TabIndex = 17;
            this.txtC.Text = "";
            // 
            // txtB
            // 
            this.txtB.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtB.Location = new System.Drawing.Point(139, 87);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(478, 53);
            this.txtB.TabIndex = 16;
            this.txtB.Text = "";
            // 
            // txtA
            // 
            this.txtA.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtA.Location = new System.Drawing.Point(139, 19);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(478, 53);
            this.txtA.TabIndex = 15;
            this.txtA.Text = "";
            // 
            // radioE
            // 
            this.radioE.AutoSize = true;
            this.radioE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioE.Location = new System.Drawing.Point(24, 311);
            this.radioE.Name = "radioE";
            this.radioE.Size = new System.Drawing.Size(49, 24);
            this.radioE.TabIndex = 14;
            this.radioE.TabStop = true;
            this.radioE.Text = "E :";
            this.radioE.UseVisualStyleBackColor = true;
            // 
            // radioD
            // 
            this.radioD.AutoSize = true;
            this.radioD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioD.Location = new System.Drawing.Point(24, 240);
            this.radioD.Name = "radioD";
            this.radioD.Size = new System.Drawing.Size(50, 24);
            this.radioD.TabIndex = 13;
            this.radioD.TabStop = true;
            this.radioD.Text = "D :";
            this.radioD.UseVisualStyleBackColor = true;
            // 
            // radioC
            // 
            this.radioC.AutoSize = true;
            this.radioC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioC.Location = new System.Drawing.Point(24, 169);
            this.radioC.Name = "radioC";
            this.radioC.Size = new System.Drawing.Size(49, 24);
            this.radioC.TabIndex = 12;
            this.radioC.TabStop = true;
            this.radioC.Text = "C :";
            this.radioC.UseVisualStyleBackColor = true;
            // 
            // radioB
            // 
            this.radioB.AutoSize = true;
            this.radioB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioB.Location = new System.Drawing.Point(24, 98);
            this.radioB.Name = "radioB";
            this.radioB.Size = new System.Drawing.Size(49, 24);
            this.radioB.TabIndex = 11;
            this.radioB.TabStop = true;
            this.radioB.Text = "B :";
            this.radioB.UseVisualStyleBackColor = true;
            // 
            // radioA
            // 
            this.radioA.AutoSize = true;
            this.radioA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioA.Location = new System.Drawing.Point(24, 27);
            this.radioA.Name = "radioA";
            this.radioA.Size = new System.Drawing.Size(49, 24);
            this.radioA.TabIndex = 10;
            this.radioA.TabStop = true;
            this.radioA.Text = "A :";
            this.radioA.UseVisualStyleBackColor = true;
            // 
            // txtBosluk
            // 
            this.txtBosluk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBosluk.Location = new System.Drawing.Point(239, 180);
            this.txtBosluk.Name = "txtBosluk";
            this.txtBosluk.Size = new System.Drawing.Size(223, 22);
            this.txtBosluk.TabIndex = 1;
            this.txtBosluk.Visible = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Location = new System.Drawing.Point(117, 614);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(67, 23);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "PUAN :";
            // 
            // txtPuan
            // 
            this.txtPuan.BackColor = System.Drawing.Color.LightCoral;
            this.txtPuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPuan.Location = new System.Drawing.Point(199, 611);
            this.txtPuan.Name = "txtPuan";
            this.txtPuan.Size = new System.Drawing.Size(100, 29);
            this.txtPuan.TabIndex = 6;
            // 
            // lblUyarı
            // 
            this.lblUyarı.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUyarı.Location = new System.Drawing.Point(184, 158);
            this.lblUyarı.Name = "lblUyarı";
            this.lblUyarı.Size = new System.Drawing.Size(334, 13);
            this.lblUyarı.TabIndex = 7;
            this.lblUyarı.Text = "Birden fazla boşluk doldurma cevapları için virgül kullanınız.";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnKaydet.Appearance.BackColor2 = System.Drawing.Color.Yellow;
            this.btnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Appearance.Options.UseBackColor = true;
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnKaydet.Location = new System.Drawing.Point(560, 609);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(107, 40);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Location = new System.Drawing.Point(24, 12);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(96, 14);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Soru Numarası :";
            // 
            // txtSıra
            // 
            this.txtSıra.BackColor = System.Drawing.Color.Tan;
            this.txtSıra.Location = new System.Drawing.Point(127, 9);
            this.txtSıra.Name = "txtSıra";
            this.txtSıra.Size = new System.Drawing.Size(38, 20);
            this.txtSıra.TabIndex = 10;
            // 
            // btnSoruyaGit
            // 
            this.btnSoruyaGit.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSoruyaGit.Appearance.Options.UseBackColor = true;
            this.btnSoruyaGit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnSoruyaGit.Image = ((System.Drawing.Image)(resources.GetObject("btnSoruyaGit.Image")));
            this.btnSoruyaGit.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnSoruyaGit.Location = new System.Drawing.Point(171, 7);
            this.btnSoruyaGit.Name = "btnSoruyaGit";
            this.btnSoruyaGit.Size = new System.Drawing.Size(33, 23);
            this.btnSoruyaGit.TabIndex = 11;
            this.btnSoruyaGit.Click += new System.EventHandler(this.btnSoruyaGit_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Location = new System.Drawing.Point(486, 9);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(87, 14);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "Toplam Puan :";
            // 
            // lblPuan
            // 
            this.lblPuan.Appearance.BackColor = System.Drawing.Color.White;
            this.lblPuan.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPuan.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.lblPuan.Location = new System.Drawing.Point(580, 9);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(24, 23);
            this.lblPuan.TabIndex = 13;
            this.lblPuan.Text = "00";
            // 
            // FrmSoruEkle
            // 
            this.AcceptButton = this.btnKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(821, 653);
            this.Controls.Add(this.lblPuan);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.btnSoruyaGit);
            this.Controls.Add(this.txtSıra);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.lblUyarı);
            this.Controls.Add(this.txtBosluk);
            this.Controls.Add(this.txtPuan);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.grupSecenekler);
            this.Controls.Add(this.radioBosluk);
            this.Controls.Add(this.radioSecenek);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtSoru);
            this.Name = "FrmSoruEkle";
            this.Text = "SORU EKLEME PLATFORMU";
            this.Load += new System.EventHandler(this.FrmSoruEkle_Load);
            this.grupSecenekler.ResumeLayout(false);
            this.grupSecenekler.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtSoru;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.RadioButton radioSecenek;
        private System.Windows.Forms.RadioButton radioBosluk;
        private System.Windows.Forms.GroupBox grupSecenekler;
        private System.Windows.Forms.TextBox txtBosluk;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox txtPuan;
        private System.Windows.Forms.RichTextBox txtD;
        private System.Windows.Forms.RichTextBox txtC;
        private System.Windows.Forms.RichTextBox txtB;
        private System.Windows.Forms.RichTextBox txtA;
        private System.Windows.Forms.RadioButton radioE;
        private System.Windows.Forms.RadioButton radioD;
        private System.Windows.Forms.RadioButton radioC;
        private System.Windows.Forms.RadioButton radioB;
        private System.Windows.Forms.RadioButton radioA;
        private System.Windows.Forms.RichTextBox txtE;
        private DevExpress.XtraEditors.LabelControl lblUyarı;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.TextBox txtSıra;
        private DevExpress.XtraEditors.SimpleButton btnSoruyaGit;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lblPuan;
    }
}