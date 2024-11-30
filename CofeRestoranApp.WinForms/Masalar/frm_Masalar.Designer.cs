namespace CofeRestoranApp.WinForms.Masalar
{
    partial class frm_Masalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Masalar));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_Guncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btn_cisix_et = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Duzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Sil = new DevExpress.XtraEditors.SimpleButton();
            this.brn_Elave_Et = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasaAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDurumu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRezervasiya = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colElaveOlmaTarixi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSonIslemTarixi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIslem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKullaniciId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasaHaraketleri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_Durum = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Rezev = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(1552, 43);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Masalar";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btn_Guncelle);
            this.groupControl1.Controls.Add(this.btn_Duzenle);
            this.groupControl1.Controls.Add(this.brn_Elave_Et);
            this.groupControl1.Controls.Add(this.btn_Rezev);
            this.groupControl1.Controls.Add(this.btn_Durum);
            this.groupControl1.Controls.Add(this.btn_cisix_et);
            this.groupControl1.Controls.Add(this.btn_Sil);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 506);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1552, 111);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Əməliyyatlar";
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guncelle.Appearance.Options.UseFont = true;
            this.btn_Guncelle.Appearance.Options.UseTextOptions = true;
            this.btn_Guncelle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btn_Guncelle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Guncelle.ImageOptions.SvgImage")));
            this.btn_Guncelle.Location = new System.Drawing.Point(372, 34);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(174, 60);
            this.btn_Guncelle.TabIndex = 4;
            this.btn_Guncelle.Text = "Güncəllə";
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // btn_cisix_et
            // 
            this.btn_cisix_et.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cisix_et.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cisix_et.Appearance.Options.UseFont = true;
            this.btn_cisix_et.Appearance.Options.UseTextOptions = true;
            this.btn_cisix_et.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btn_cisix_et.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_cisix_et.ImageOptions.SvgImage")));
            this.btn_cisix_et.Location = new System.Drawing.Point(1415, 34);
            this.btn_cisix_et.Name = "btn_cisix_et";
            this.btn_cisix_et.Size = new System.Drawing.Size(125, 60);
            this.btn_cisix_et.TabIndex = 3;
            this.btn_cisix_et.Text = "Çıxış";
            // 
            // btn_Duzenle
            // 
            this.btn_Duzenle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Duzenle.Appearance.Options.UseFont = true;
            this.btn_Duzenle.Appearance.Options.UseTextOptions = true;
            this.btn_Duzenle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btn_Duzenle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Duzenle.ImageOptions.SvgImage")));
            this.btn_Duzenle.Location = new System.Drawing.Point(192, 34);
            this.btn_Duzenle.Name = "btn_Duzenle";
            this.btn_Duzenle.Size = new System.Drawing.Size(174, 60);
            this.btn_Duzenle.TabIndex = 2;
            this.btn_Duzenle.Text = "Dəyişdir";
            this.btn_Duzenle.Click += new System.EventHandler(this.btn_Duzenle_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Sil.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sil.Appearance.Options.UseFont = true;
            this.btn_Sil.Appearance.Options.UseTextOptions = true;
            this.btn_Sil.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btn_Sil.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Sil.ImageOptions.SvgImage")));
            this.btn_Sil.Location = new System.Drawing.Point(1284, 34);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(125, 60);
            this.btn_Sil.TabIndex = 1;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // brn_Elave_Et
            // 
            this.brn_Elave_Et.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brn_Elave_Et.Appearance.Options.UseFont = true;
            this.brn_Elave_Et.Appearance.Options.UseTextOptions = true;
            this.brn_Elave_Et.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.brn_Elave_Et.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("brn_Elave_Et.ImageOptions.SvgImage")));
            this.brn_Elave_Et.Location = new System.Drawing.Point(12, 34);
            this.brn_Elave_Et.Name = "brn_Elave_Et";
            this.brn_Elave_Et.Size = new System.Drawing.Size(174, 60);
            this.brn_Elave_Et.TabIndex = 0;
            this.brn_Elave_Et.Text = "Əlavə et";
            this.brn_Elave_Et.Click += new System.EventHandler(this.brn_Elave_Et_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 43);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1552, 463);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colMasaAdi,
            this.colAciklama,
            this.colDurumu,
            this.colRezervasiya,
            this.colElaveOlmaTarixi,
            this.colSonIslemTarixi,
            this.colIslem,
            this.colKullaniciId,
            this.colMasaHaraketleri});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colId
            // 
            this.colId.Caption = "ID";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 66;
            // 
            // colMasaAdi
            // 
            this.colMasaAdi.Caption = "Masa";
            this.colMasaAdi.FieldName = "MasaAdi";
            this.colMasaAdi.Name = "colMasaAdi";
            this.colMasaAdi.Visible = true;
            this.colMasaAdi.VisibleIndex = 1;
            this.colMasaAdi.Width = 163;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Məlumat";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 2;
            this.colAciklama.Width = 343;
            // 
            // colDurumu
            // 
            this.colDurumu.FieldName = "Durumu";
            this.colDurumu.Name = "colDurumu";
            this.colDurumu.Visible = true;
            this.colDurumu.VisibleIndex = 3;
            this.colDurumu.Width = 95;
            // 
            // colRezervasiya
            // 
            this.colRezervasiya.FieldName = "Rezervasiya";
            this.colRezervasiya.Name = "colRezervasiya";
            this.colRezervasiya.Visible = true;
            this.colRezervasiya.VisibleIndex = 4;
            this.colRezervasiya.Width = 92;
            // 
            // colElaveOlmaTarixi
            // 
            this.colElaveOlmaTarixi.FieldName = "ElaveOlmaTarixi";
            this.colElaveOlmaTarixi.Name = "colElaveOlmaTarixi";
            this.colElaveOlmaTarixi.Visible = true;
            this.colElaveOlmaTarixi.VisibleIndex = 5;
            this.colElaveOlmaTarixi.Width = 127;
            // 
            // colSonIslemTarixi
            // 
            this.colSonIslemTarixi.FieldName = "SonIslemTarixi";
            this.colSonIslemTarixi.Name = "colSonIslemTarixi";
            this.colSonIslemTarixi.Visible = true;
            this.colSonIslemTarixi.VisibleIndex = 6;
            this.colSonIslemTarixi.Width = 125;
            // 
            // colIslem
            // 
            this.colIslem.FieldName = "Islem";
            this.colIslem.Name = "colIslem";
            this.colIslem.Visible = true;
            this.colIslem.VisibleIndex = 8;
            this.colIslem.Width = 327;
            // 
            // colKullaniciId
            // 
            this.colKullaniciId.Caption = "Ad / Soyad";
            this.colKullaniciId.FieldName = "kullanici";
            this.colKullaniciId.Name = "colKullaniciId";
            this.colKullaniciId.Visible = true;
            this.colKullaniciId.VisibleIndex = 7;
            this.colKullaniciId.Width = 165;
            // 
            // colMasaHaraketleri
            // 
            this.colMasaHaraketleri.FieldName = "MasaHaraketleri";
            this.colMasaHaraketleri.Name = "colMasaHaraketleri";
            // 
            // btn_Durum
            // 
            this.btn_Durum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Durum.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Durum.Appearance.Options.UseFont = true;
            this.btn_Durum.Appearance.Options.UseTextOptions = true;
            this.btn_Durum.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btn_Durum.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.btn_Durum.Location = new System.Drawing.Point(1022, 34);
            this.btn_Durum.Name = "btn_Durum";
            this.btn_Durum.Size = new System.Drawing.Size(125, 60);
            this.btn_Durum.TabIndex = 5;
            this.btn_Durum.Text = "Durum\r\nDəyişdir\r\n";
            // 
            // btn_Rezev
            // 
            this.btn_Rezev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Rezev.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Rezev.Appearance.Options.UseFont = true;
            this.btn_Rezev.Appearance.Options.UseTextOptions = true;
            this.btn_Rezev.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btn_Rezev.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.btn_Rezev.Location = new System.Drawing.Point(1153, 34);
            this.btn_Rezev.Name = "btn_Rezev";
            this.btn_Rezev.Size = new System.Drawing.Size(125, 60);
            this.btn_Rezev.TabIndex = 6;
            this.btn_Rezev.Text = "Rezervasiya\r\nEt";
            // 
            // frm_Masalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1552, 617);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "frm_Masalar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Masalar";
            this.Load += new System.EventHandler(this.frm_Masalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Guncelle;
        private DevExpress.XtraEditors.SimpleButton btn_cisix_et;
        private DevExpress.XtraEditors.SimpleButton btn_Duzenle;
        private DevExpress.XtraEditors.SimpleButton btn_Sil;
        private DevExpress.XtraEditors.SimpleButton brn_Elave_Et;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colMasaAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colDurumu;
        private DevExpress.XtraGrid.Columns.GridColumn colRezervasiya;
        private DevExpress.XtraGrid.Columns.GridColumn colElaveOlmaTarixi;
        private DevExpress.XtraGrid.Columns.GridColumn colSonIslemTarixi;
        private DevExpress.XtraGrid.Columns.GridColumn colIslem;
        private DevExpress.XtraGrid.Columns.GridColumn colKullaniciId;
        private DevExpress.XtraGrid.Columns.GridColumn colMasaHaraketleri;
        private DevExpress.XtraEditors.SimpleButton btn_Rezev;
        private DevExpress.XtraEditors.SimpleButton btn_Durum;
    }
}