namespace SoruHavuzu
{
    partial class FrmSorular
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSorular));
            this.btnIleri = new DevExpress.XtraEditors.SimpleButton();
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
            this.grupSecenekler = new System.Windows.Forms.GroupBox();
            this.txtSoru = new System.Windows.Forms.RichTextBox();
            this.lblUyarı = new DevExpress.XtraEditors.LabelControl();
            this.txtBosluk = new System.Windows.Forms.TextBox();
            this.lblSoruSirasi = new DevExpress.XtraEditors.LabelControl();
            this.lblTopPuan = new DevExpress.XtraEditors.LabelControl();
            this.btnCikis = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.grupSecenekler.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIleri
            // 
            this.btnIleri.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnIleri.Appearance.BackColor2 = System.Drawing.Color.Yellow;
            this.btnIleri.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIleri.Appearance.Options.UseBackColor = true;
            this.btnIleri.Appearance.Options.UseFont = true;
            this.btnIleri.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnIleri.Location = new System.Drawing.Point(674, 640);
            this.btnIleri.Name = "btnIleri";
            this.btnIleri.Size = new System.Drawing.Size(107, 40);
            this.btnIleri.TabIndex = 23;
            this.btnIleri.Text = "İLERİ";
            this.btnIleri.Click += new System.EventHandler(this.btnIleri_Click);
            // 
            // txtE
            // 
            this.txtE.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtE.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtE.Location = new System.Drawing.Point(139, 291);
            this.txtE.Name = "txtE";
            this.txtE.Size = new System.Drawing.Size(478, 53);
            this.txtE.TabIndex = 19;
            this.txtE.Text = "";
            // 
            // txtD
            // 
            this.txtD.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtD.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtD.Location = new System.Drawing.Point(139, 223);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(478, 53);
            this.txtD.TabIndex = 18;
            this.txtD.Text = "";
            // 
            // txtC
            // 
            this.txtC.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtC.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtC.Location = new System.Drawing.Point(139, 155);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(478, 53);
            this.txtC.TabIndex = 17;
            this.txtC.Text = "";
            // 
            // txtB
            // 
            this.txtB.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtB.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtB.Location = new System.Drawing.Point(139, 87);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(478, 53);
            this.txtB.TabIndex = 16;
            this.txtB.Text = "";
            // 
            // txtA
            // 
            this.txtA.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtA.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
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
            this.grupSecenekler.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grupSecenekler.Location = new System.Drawing.Point(164, 271);
            this.grupSecenekler.Name = "grupSecenekler";
            this.grupSecenekler.Size = new System.Drawing.Size(636, 363);
            this.grupSecenekler.TabIndex = 19;
            this.grupSecenekler.TabStop = false;
            this.grupSecenekler.Text = "SEÇENEKLER";
            this.grupSecenekler.Visible = false;
            // 
            // txtSoru
            // 
            this.txtSoru.BackColor = System.Drawing.Color.Ivory;
            this.txtSoru.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoru.Location = new System.Drawing.Point(191, 68);
            this.txtSoru.Name = "txtSoru";
            this.txtSoru.Size = new System.Drawing.Size(609, 122);
            this.txtSoru.TabIndex = 14;
            this.txtSoru.Text = "";
            // 
            // lblUyarı
            // 
            this.lblUyarı.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUyarı.Location = new System.Drawing.Point(164, 205);
            this.lblUyarı.Name = "lblUyarı";
            this.lblUyarı.Size = new System.Drawing.Size(737, 18);
            this.lblUyarı.TabIndex = 25;
            this.lblUyarı.Text = "Birden fazla boşluk doldurma cevapları için virgül kullanınız.Kelimemelerin ilk h" +
    "arfleri büyük olsun";
            // 
            // txtBosluk
            // 
            this.txtBosluk.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBosluk.Location = new System.Drawing.Point(489, 243);
            this.txtBosluk.Name = "txtBosluk";
            this.txtBosluk.Size = new System.Drawing.Size(223, 26);
            this.txtBosluk.TabIndex = 24;
            this.txtBosluk.Visible = false;
            // 
            // lblSoruSirasi
            // 
            this.lblSoruSirasi.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoruSirasi.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.lblSoruSirasi.Location = new System.Drawing.Point(62, 80);
            this.lblSoruSirasi.Name = "lblSoruSirasi";
            this.lblSoruSirasi.Size = new System.Drawing.Size(12, 23);
            this.lblSoruSirasi.TabIndex = 26;
            this.lblSoruSirasi.Text = "1";
            // 
            // lblTopPuan
            // 
            this.lblTopPuan.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTopPuan.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.lblTopPuan.Location = new System.Drawing.Point(828, 68);
            this.lblTopPuan.Name = "lblTopPuan";
            this.lblTopPuan.Size = new System.Drawing.Size(26, 25);
            this.lblTopPuan.TabIndex = 27;
            this.lblTopPuan.Text = "00";
            // 
            // btnCikis
            // 
            this.btnCikis.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCikis.Appearance.BackColor2 = System.Drawing.Color.Yellow;
            this.btnCikis.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Appearance.Options.UseBackColor = true;
            this.btnCikis.Appearance.Options.UseFont = true;
            this.btnCikis.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnCikis.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.Image")));
            this.btnCikis.Location = new System.Drawing.Point(1105, 12);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(96, 32);
            this.btnCikis.TabIndex = 28;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.labelControl1.Location = new System.Drawing.Point(870, 70);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(43, 18);
            this.labelControl1.TabIndex = 29;
            this.labelControl1.Text = "PUAN";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.labelControl2.Location = new System.Drawing.Point(12, 83);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(44, 18);
            this.labelControl2.TabIndex = 30;
            this.labelControl2.Text = "SORU";
            // 
            // FrmSorular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 749);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.lblTopPuan);
            this.Controls.Add(this.lblSoruSirasi);
            this.Controls.Add(this.lblUyarı);
            this.Controls.Add(this.txtBosluk);
            this.Controls.Add(this.btnIleri);
            this.Controls.Add(this.grupSecenekler);
            this.Controls.Add(this.txtSoru);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSorular";
            this.Text = "SINAV EKRANI";
            this.Load += new System.EventHandler(this.FrmSorular_Load);
            this.grupSecenekler.ResumeLayout(false);
            this.grupSecenekler.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnIleri;
        private System.Windows.Forms.RichTextBox txtE;
        private System.Windows.Forms.RichTextBox txtD;
        private System.Windows.Forms.RichTextBox txtC;
        private System.Windows.Forms.RichTextBox txtB;
        private System.Windows.Forms.RichTextBox txtA;
        private System.Windows.Forms.RadioButton radioE;
        private System.Windows.Forms.RadioButton radioD;
        private System.Windows.Forms.RadioButton radioC;
        private System.Windows.Forms.RadioButton radioB;
        private System.Windows.Forms.RadioButton radioA;
        private System.Windows.Forms.GroupBox grupSecenekler;
        private System.Windows.Forms.RichTextBox txtSoru;
        private DevExpress.XtraEditors.LabelControl lblUyarı;
        private System.Windows.Forms.TextBox txtBosluk;
        private DevExpress.XtraEditors.LabelControl lblSoruSirasi;
        private DevExpress.XtraEditors.LabelControl lblTopPuan;
        private DevExpress.XtraEditors.SimpleButton btnCikis;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}