namespace SoruHavuzu
{
    partial class FrmOturumListele
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gridContOturum = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnDuzenle = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSil = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNotGor = new System.Windows.Forms.ToolStripMenuItem();
            this.gridViewOturum = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.OturumAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OlusturulmaTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OturumID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BaslangicTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Sifre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BitisTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OturumSuresi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContOturum)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOturum)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 424);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gridContOturum);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(664, 324);
            this.panel3.TabIndex = 1;
            // 
            // gridContOturum
            // 
            this.gridContOturum.ContextMenuStrip = this.contextMenuStrip1;
            this.gridContOturum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContOturum.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridContOturum.Location = new System.Drawing.Point(0, 0);
            this.gridContOturum.MainView = this.gridViewOturum;
            this.gridContOturum.Name = "gridContOturum";
            this.gridContOturum.Size = new System.Drawing.Size(664, 324);
            this.gridContOturum.TabIndex = 0;
            this.gridContOturum.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewOturum});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDuzenle,
            this.btnSil,
            this.btnNotGor});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(133, 70);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(132, 22);
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(132, 22);
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnNotGor
            // 
            this.btnNotGor.Name = "btnNotGor";
            this.btnNotGor.Size = new System.Drawing.Size(132, 22);
            this.btnNotGor.Text = "Notları Gör";
            this.btnNotGor.Click += new System.EventHandler(this.btnNotGor_Click);
            // 
            // gridViewOturum
            // 
            this.gridViewOturum.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.OturumAdi,
            this.OlusturulmaTarihi,
            this.OturumID,
            this.BaslangicTarihi,
            this.Sifre,
            this.BitisTarihi,
            this.OturumSuresi});
            this.gridViewOturum.GridControl = this.gridContOturum;
            this.gridViewOturum.Name = "gridViewOturum";
            this.gridViewOturum.OptionsView.ShowAutoFilterRow = true;
            this.gridViewOturum.OptionsView.ShowGroupPanel = false;
            // 
            // OturumAdi
            // 
            this.OturumAdi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OturumAdi.AppearanceHeader.Options.UseFont = true;
            this.OturumAdi.Caption = "Oturum Adı";
            this.OturumAdi.FieldName = "OturumAdi";
            this.OturumAdi.Name = "OturumAdi";
            this.OturumAdi.Visible = true;
            this.OturumAdi.VisibleIndex = 0;
            // 
            // OlusturulmaTarihi
            // 
            this.OlusturulmaTarihi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OlusturulmaTarihi.AppearanceHeader.Options.UseFont = true;
            this.OlusturulmaTarihi.Caption = "Oluşturulma Tarihi";
            this.OlusturulmaTarihi.FieldName = "OlusturulmaTarihi";
            this.OlusturulmaTarihi.Name = "OlusturulmaTarihi";
            this.OlusturulmaTarihi.Visible = true;
            this.OlusturulmaTarihi.VisibleIndex = 3;
            // 
            // OturumID
            // 
            this.OturumID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OturumID.AppearanceHeader.Options.UseFont = true;
            this.OturumID.Caption = "OturumID";
            this.OturumID.FieldName = "OturumID";
            this.OturumID.Name = "OturumID";
            // 
            // BaslangicTarihi
            // 
            this.BaslangicTarihi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BaslangicTarihi.AppearanceHeader.Options.UseFont = true;
            this.BaslangicTarihi.Caption = "Başlangıç Tarihi";
            this.BaslangicTarihi.FieldName = "BaslangicTarihi";
            this.BaslangicTarihi.Name = "BaslangicTarihi";
            this.BaslangicTarihi.Visible = true;
            this.BaslangicTarihi.VisibleIndex = 4;
            // 
            // Sifre
            // 
            this.Sifre.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sifre.AppearanceHeader.Options.UseFont = true;
            this.Sifre.Caption = "Şifre";
            this.Sifre.FieldName = "Sifre";
            this.Sifre.Name = "Sifre";
            this.Sifre.Visible = true;
            this.Sifre.VisibleIndex = 1;
            // 
            // BitisTarihi
            // 
            this.BitisTarihi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BitisTarihi.AppearanceHeader.Options.UseFont = true;
            this.BitisTarihi.Caption = "Bitiş Tarihi";
            this.BitisTarihi.FieldName = "BitisTarihi";
            this.BitisTarihi.Name = "BitisTarihi";
            this.BitisTarihi.Visible = true;
            this.BitisTarihi.VisibleIndex = 5;
            // 
            // OturumSuresi
            // 
            this.OturumSuresi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OturumSuresi.AppearanceHeader.Options.UseFont = true;
            this.OturumSuresi.Caption = "Oturum Süresi";
            this.OturumSuresi.FieldName = "Sure";
            this.OturumSuresi.Name = "OturumSuresi";
            this.OturumSuresi.Visible = true;
            this.OturumSuresi.VisibleIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(664, 100);
            this.panel2.TabIndex = 0;
            // 
            // FrmOturumListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(664, 424);
            this.Controls.Add(this.panel1);
            this.Name = "FrmOturumListele";
            this.Text = "OTURUM LİSTELEME";
            this.Load += new System.EventHandler(this.FrmOturumListele_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridContOturum)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOturum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gridContOturum;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewOturum;
        private DevExpress.XtraGrid.Columns.GridColumn OturumAdi;
        private DevExpress.XtraGrid.Columns.GridColumn OlusturulmaTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn OturumID;
        private DevExpress.XtraGrid.Columns.GridColumn BaslangicTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn Sifre;
        private DevExpress.XtraGrid.Columns.GridColumn BitisTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn OturumSuresi;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnDuzenle;
        private System.Windows.Forms.ToolStripMenuItem btnSil;
        private System.Windows.Forms.ToolStripMenuItem btnNotGor;
    }
}